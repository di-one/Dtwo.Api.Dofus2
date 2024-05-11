using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Dtwo.API.DofusBase.Reflection;
using System.Diagnostics;
using Dtwo.API.DofusBase;

namespace Dtwo.API.Dofus2.Encoding
{ 
    public static class ProtocolTypeManager
    {

        private static readonly Dictionary<short, Type> m_types = new Dictionary<short, Type>(500);
        private static readonly Dictionary<short, Func<object>> m_typesConstructors = new Dictionary<short, Func<object>>(500);

        public static void Init()
        {
            InitializeTypes(Dtwo.API.Paths.Dofus2BindingTypesPath);

        }

        private static bool InitializeTypes(string filePath)
        {
            if (File.Exists(filePath) == false)
            {
                LogManager.LogError($"Error on Initialize messages : file {filePath} not found", 1);
                return false;
            }

            string content = File.ReadAllText(filePath);
            List<DofusTypeBinding> bindings;
            try
            {
                bindings = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DofusTypeBinding>>(content);
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex.ToString());
                return false;
            }

            var asm = Assembly.GetAssembly(typeof(ProtocolTypeManager)); // Random type of Dtwo.API.Dofus2
            var asmTypes = asm.GetExportedTypes();
            for (int i = 0; i < asmTypes.Length; i++)
            {
                var type = asmTypes[i];

                if (type.IsClass && type.IsAbstract == false && type.Namespace.StartsWith(typeof(AnkamaGames.Network.Types.GameServerInformations).Namespace))
                {
                    var binding = GetBinding(type, bindings);

                    if (binding == null || binding.Identifier == null) continue;

                    short identifier;
                    if (short.TryParse(binding.Identifier, out identifier) == false)
                    {
                        LogManager.LogWarning(
                            $"{nameof(ProtocolTypeManager)}.{nameof(InitializeTypes)}",
                            $"Error on MessageLoader.LoadMessage : The key {binding.Identifier} is not a valid identifier");
                        continue;
                    }

                    if (m_types.ContainsKey(identifier)) // error
                    {
                        LogManager.LogWarning(
                            $"{nameof(ProtocolTypeManager)}.{nameof(InitializeTypes)}", 
                            $"Error on MessageLoader.LoadMessage : The key {binding.Identifier} aleady exist");
                        continue;
                    }

                    ConstructorInfo? ctor = type.GetConstructor(Type.EmptyTypes);
                    if (ctor == null)
                    {
                        LogManager.LogWarning(
                            $"{nameof(ProtocolTypeManager)}.{nameof(InitializeTypes)}", 
                            $"Error on MessageLoader.LoadMessage : The key {binding.Identifier} has no constructor");
                        continue;
                    }

                    m_types.Add(identifier, type);
                    m_typesConstructors.Add(identifier, ctor.CreateDelegate<Func<object>>());
                }
            }

            LogManager.Log($"Register {m_types.Count} types");

            return true;
        }

        private static DofusTypeBinding? GetBinding(Type messageType, List<DofusTypeBinding> bindings)
        {
            string str = messageType.Name;

            for (int i = 0; i < bindings.Count; i++)
            {
                var binding = bindings[i];

                if (binding.ClassName == str)
                {
                    return binding;
                }
            }

            return null;
        }

        public static T GetInstance<T>(ushort id) where T : class
        {
            if (!m_types.ContainsKey((short)id))
            {
                LogManager.LogWarning(
                    $"{nameof(ProtocolTypeManager)}.{nameof(GetInstance)}",
                    string.Format("Type <id:{0}> doesn't exist", id));
            }

            return m_typesConstructors[(short)id]() as T;
        }

        public static T GetInstance<T>(short id) where T : class
        {
            if (!m_types.ContainsKey(id))
            {
                LogManager.LogWarning(string.Format("Type <id:{0}> doesn't exist", id));
            }

            return m_typesConstructors[id]() as T;
        }

        [Serializable]
        public class ProtocolTypeNotFoundException : System.Exception
        {
            public ProtocolTypeNotFoundException()
            {
            }

            public ProtocolTypeNotFoundException(string message)
                : base(message)
            {
            }

            public ProtocolTypeNotFoundException(string message, System.Exception inner)
                : base(message, inner)
            {
            }

            protected ProtocolTypeNotFoundException(
                SerializationInfo info,
                StreamingContext context)
                : base(info, context)
            {
            }
        }

    }
}
