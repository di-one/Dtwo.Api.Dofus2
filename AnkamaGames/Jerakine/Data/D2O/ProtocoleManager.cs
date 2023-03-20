using RaidBot.Data.IO.D2O.DataCenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Dtwo.API.DofusBase.Data;
using Dtwo.API.Dofus2.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RaidBot.Data.IO.D2O
{
    public class ProtocolManager
    {

        #region Declarations

        private static Dictionary<string, Type> DataClasses;
        private static bool DataClassesInitialized = false;

        #endregion

        #region Public methode

        public static DofusData GetDataClass(string name)
        {
            if (!DataClassesInitialized)
                Ini();
            if (DataClasses.Any(key => key.Key == name))
                return (DofusData)Activator.CreateInstance(DataClasses[name]);
            else
            {
                Console.WriteLine($"Data class {name} not found");
                return null;
            }
        }

        #endregion

        #region Private methode

        private static void Ini()
        {
            Console.WriteLine("Init protocole manager with asm type DofusData");
            DataClasses = new Dictionary<string, Type>();
            Assembly assembly = Assembly.GetAssembly(typeof(ProtocolManager));
            foreach (Type t in assembly.GetTypes())
            {
                if (t.IsAssignableTo(typeof(DofusData)))
                {
                    Console.WriteLine("Add class : " + t.ToString());
                    string className = t.ToString();
                    string[] splited = className.Split('.');
                    className = splited[splited.Length - 1];
                    Console.WriteLine("Add class confirm : " + className);
                    DataClasses.Add(className, t);
                }
            }
            DataClassesInitialized = true;


            #endregion
        }
    }
}
