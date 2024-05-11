using System.Reflection;
using Dtwo.API.Dofus2.AnkamaGames.Atouin;
using Dtwo.API.DofusBase.Reflection;

namespace Dtwo.API.Dofus2.AnkamaGames.Jerakine.Data
{
    public class DataCenterTypeManager
    {
        #region Attributs
        private static readonly Dictionary<string, Type> m_Types = new Dictionary<string, Type>();
        private static readonly Dictionary<string, Func<object>> m_TypesConstructors = new Dictionary<string, Func<object>>();
        #endregion

        #region Constructeurs
        public static bool Init()
        {
            LogManager.Log("DataCenterTypeManager init");
            Assembly asm = Assembly.GetAssembly(typeof(DataCenterTypeManager));

            foreach (Type type in asm.GetTypes())
            {

                if (type.Namespace != "Dtwo.API.Dofus2.AnkamaGames.Dofus.DataCenter") continue;

                m_Types.Add(type.Name, type);

                ConstructorInfo ctor = type.GetConstructor(Type.EmptyTypes);

                if (ctor == null)
                {
                    LogManager.LogError(
                        $"{nameof(DataCenterTypeManager)}.{nameof(Init)}", 
                        string.Format("'{0}' doesn't implemented a parameterless constructor", type));

                    return false;
                }

                m_TypesConstructors.Add(type.Name, ctor.CreateDelegate<Func<object>>());
            }

            return true;
        }
        #endregion

        #region Méthodes publiques
        public static T GetInstance<T>(string name) where T : class
        {
            if (!m_TypesConstructors.ContainsKey(name))
            {
                LogManager.LogWarning($"{nameof(DataCenterTypeManager)}.{nameof(GetInstance)}", "Type " + name + " doesn't exist");
                return null;
            }

            var constructor = m_TypesConstructors[name]();

            var castedConstructor = constructor as T;

            return castedConstructor;
        }
        #endregion
    }
}