using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Security.Cryptography;
using Dtwo.API.Dofus2.AnkamaGames.Dofus.DataCenter;
using Dtwo.API.Dofus2.Data;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.DofusBase.Data;
using Microsoft.VisualBasic.FileIO;

namespace Dtwo.API.Dofus2.AnkamaGames.Jerakine.Data
{
    public class GameDataClassDefinition
    {
        #region Attributs
        private readonly GameDataFileAccessor m_GameDataFileAccessor;
        private readonly DofusData m_Class;
        private readonly List<GameDataField> m_Fields;
        #endregion

        #region Propriéts
        public List<GameDataField> Fields
        {
            get { return m_Fields; }
        }
        #endregion

        #region Constructeurs
        public GameDataClassDefinition(GameDataFileAccessor gameDataFileAccessor, string className, string namespaceName)
        {
            m_GameDataFileAccessor = gameDataFileAccessor;
            m_Class = DataCenterTypeManager.GetInstance<DofusData>(className);
            m_Fields = new List<GameDataField>();
        }
        #endregion

        #region Méthodes publiques
        public DofusData Read(string className, BigEndianReader reader)
        {
            LogManager.Log("Read : " + className);

            if (m_Class == null)
            {
                LogManager.LogError($"Unable to read the class {className} : the class is null");
                return null;
            }

            Type type = m_Class.GetType();
            
            ConstructorInfo[] constructors = type.GetConstructors();
            ParameterInfo[] constructorParameters = constructors[0].GetParameters();
            List<object> parameters = new List<object>();

            //foreach (ParameterInfo parameter in constructorParameters)
            //{
            //    if (parameter.Name == "gameDataFileAccessor")
            //    {
            //        parameters.Add(m_GameDataFileAccessor);
            //        continue;
            //    }

            //    foreach (GameDataField field in m_Fields)
            //    {

            //        if (parameter.Name.ToLower() == field.Name.ToLower())
            //        {
            //            parameters.Add(field.Value);
            //            break;
            //        }
            //    }
            //}

            object result = constructors[0].Invoke(parameters.ToArray());


            foreach (GameDataField field in m_Fields)
            {
                field.Read(className, reader);
            }

            System.Reflection.FieldInfo[] ps = result.GetType().GetFields();
            foreach (var item in ps)
            {
                var field = m_Fields.Find(x => x.Name == item.Name);
                if (field == null) continue;

                Console.WriteLine($"field: {field.Name}");

                var safeValue = SafeParse(field.Value, item.FieldType);

                try
                {
                    item.SetValue(result, safeValue);
                }
                catch (Exception ex)
                {
                    LogManager.LogError(ex.ToString());
                    continue;
                }
            }


            return (DofusData)result;
        }

        private object SafeParse(object val1, Type type)
        {
            if (val1 == null)
            {
                return null;
            }

            var typeVal1 = val1.GetType();
            object res = null;

            Type t = Nullable.GetUnderlyingType(type) ?? type;
            TypeConverter converter = TypeDescriptor.GetConverter(t);
            object safeValue = val1;

            if (converter.CanConvertFrom(typeVal1))
            {
                return converter.ConvertFrom(val1);
            }

            try
            {
                if (type == typeof(UInt32) && typeVal1 == typeof(Int32))
                {
                    var val = (Int32)val1;
                    UInt32 resVal = 0;
                    if (val < 0)
                    {
                        resVal = 0;
                    }
                    else
                    {
                        resVal = (UInt32)val;
                    }

                    res = resVal;
                }
                else if (type == typeof(Int32) && typeVal1 == typeof(UInt32))
                {
                    var val = (UInt32)val1;
                    Int32 resVal = 0;
                    if (val < 0)
                    {
                        resVal = 0;
                    }
                    else
                    {
                        resVal = (Int32)val;
                    }

                    res = resVal;
                }
                else if (type == typeof(IList))
                {
                    var t2 = type.GetGenericArguments()[0];

                    var list = (IList)val1;
                    var newList = (IList)Activator.CreateInstance(type);
                    foreach(var l in list)
                    {
                        var parse = SafeParse(l, t2);
                        if (parse == null)
                        {
                            continue;
                        }

                        newList.Add(parse);
                    }

                    res = newList;
                }
            }
            catch (Exception ex)
            {
                LogManager.LogError(ex.ToString());

                return null;
            }

            return res;
        }

        public void AddField(string fieldName, BigEndianReader reader)
        {
            GameDataField gameDataField = new GameDataField(fieldName);

            gameDataField.ReadType(reader);

            m_Fields.Add(gameDataField);
        }

        public void SetFields(Dictionary<string, Dictionary<int, GameDataClassDefinition>> classes)
        {
            foreach (GameDataField gameDataField in m_Fields)
                gameDataField.SetClasses(classes);
        }
        #endregion
    }
}
