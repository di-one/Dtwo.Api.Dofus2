using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using RaidBot.Data.IO.D2O.DataCenter;
using System.Collections;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.DofusBase.Data;

namespace RaidBot.Data.IO.D2O
{
    public class GameDataClassDefiniton
    {
        #region Declarations

        public string ClassName { get; private set; }
        private DofusData classe;
        public List<GameDataField> Fields { get; private set; }

        #endregion

        #region Methode

        #region Public

        public GameDataClassDefiniton(string className)
        {
            Fields = new List<GameDataField>();
            ClassName = className;
            classe = ProtocolManager.GetDataClass(className);
        }

        public void AddField(string fieldName, BigEndianReader reader)
        {
            Fields.Add(new GameDataField(fieldName, reader));
        }

        public void SetField(Dictionary<int, GameDataClassDefiniton> classes)
        {
            foreach (GameDataField field in Fields)
            {
                field.SetClasses(classes);
            }
        }

        public DofusData Read(BigEndianReader reader)
        {
            if (classe == null)
            {
                //Console.WriteLine("Game data class definition : class null");
                return null;
            }
      

            Type type = classe.GetType();

            DofusData retVal = (DofusData)Activator.CreateInstance(type);
            var properities = type.GetFields();

            foreach (GameDataField field in Fields)
            {
                field.Read(reader, ClassName);
            }
            foreach (var properity in properities)
            {
                //Console.WriteLine("Add properties ? " + properity.Name);
                foreach (GameDataField field in Fields)
                {
                    //Console.WriteLine("check field " + field.Name);
                    if (field.Name.ToLower().Replace("_", "") == properity.Name.ToLower().Replace("_", ""))
                    {
                        //Console.WriteLine("check field 2 " + field.Name);
                        //if (properity.)
                        //{
                            //Console.WriteLine($"Add property {properity.Name}");
                            properity.SetValue(retVal, GetValue(field.Value, properity.FieldType));
                        //}
                    }
                }
            }
            return retVal;
        }



        private Type GetItemType(Type collectionType)
        {
            return collectionType.GetMethod("get_Item").ReturnType;
        }
        private object GetValue(object value, Type t)
        {
            object retVal = value;
            if (value == null)
                return null;
            if (t.GetInterface("IList") != null)
            {
                Type genericType = GetItemType(t);
                var type = typeof(List<>).MakeGenericType(genericType);
                IList a_Context = (IList)Activator.CreateInstance(type);
                List<object> objectList = (List<object>)value;
                foreach (var obj in objectList)
                {
                    if (obj != null)
                    {
                        if (genericType.GetInterface("IList") != null || obj.GetType().GetInterface("IConvertible") == null)
                        {
                            a_Context.Add(GetValue(obj, genericType));
                        }
                        else if (obj.GetType().GetInterface("IConvertible") != null)
                            a_Context.Add(Convert.ChangeType(obj, genericType));
                    }
                }
                retVal = a_Context;
            }
            else
            {
                try
                {
                    retVal = Convert.ChangeType(value, t);
                }
                catch (OverflowException e)
                {
                    return Convert.ChangeType(0, t);
                }
                catch
                {

                }
            }
            return retVal;
        }

        private List<T> CreateList<T>(params T[] elements)
        {
            return new List<T>(elements);
        }

        #endregion

        #region Privée

        #endregion

        #endregion
    }
}
