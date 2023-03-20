using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Dtwo.API.DofusBase.Reflection;

namespace Dtwo.API.Dofus2.Encoding
{ 
    public static class ProtocolTypeManager
    {

        private static readonly Dictionary<short, Type> types = new Dictionary<short, Type>(500);
        private static readonly Dictionary<short, Func<object>> typesConstructors = new Dictionary<short, Func<object>>(500);

        public static void Init()
        {
            Assembly asm = Assembly.GetAssembly(typeof(ProtocolTypeManager));

            int registerTypes = 0;

            foreach (Type type in asm.GetTypes())
            {
                if (type.Namespace == null || !type.Namespace.StartsWith(typeof(AnkamaGames.Network.Types.GameServerInformations).Namespace))
                    continue;

                FieldInfo field = type.GetField("Id");

                if (field != null)
                {
                    // le cast uint est obligatoire car l'objet n'a pas de type
                    short id = (short)(field.GetValue(type));

                    types.Add(id, type);

                    ConstructorInfo ctor = type.GetConstructor(Type.EmptyTypes);

                    if (ctor == null)
                        Console.WriteLine(string.Format("'{0}' doesn't implemented a parameterless constructor", type));

                    typesConstructors.Add(id, ctor.CreateDelegate<Func<object>>());
                    registerTypes++;
                }
            }

            Console.WriteLine($"Register {registerTypes} types");
        }

        public static T GetInstance<T>(ushort id) where T : class
        {
            if (!types.ContainsKey((short)id))
            {
                Console.WriteLine(string.Format("Type <id:{0}> doesn't exist", id));
            }

            return typesConstructors[(short)id]() as T;
        }

        public static T GetInstance<T>(short id) where T : class
        {
            if (!types.ContainsKey(id))
            {
                Console.WriteLine(string.Format("Type <id:{0}> doesn't exist", id));
            }

            return typesConstructors[id]() as T;
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
