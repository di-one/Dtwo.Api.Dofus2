using Dtwo.API.DofusBase.Data;
using RaidBot.Data.IO.D2O.DataCenter;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RaidBot.Data.IO.D2O
{
    public static class GameDataManager
    {
        private static Dictionary<String, String> DataFiles;
        private static ConcurrentDictionary<String, GameDataFileAccessor> Accessors;

        
        public static void Init(String path)
        {
            Accessors = new ConcurrentDictionary<string, GameDataFileAccessor>();
            DataFiles = new Dictionary<String, String>();
            string[] paths = Directory.GetFiles(path);
            foreach (string file in paths)
            {
                DataFiles.Add(Path.GetFileName(file).Split('.')[0], file);
            }
        }

        public static T GetObject<T>(int id) where T : DofusData
        {
            String name = typeof(T).Name;
            if (!Accessors.ContainsKey(name))
                Accessors[name] = new GameDataFileAccessor(DataFiles[name + "s"]);
            return Accessors[name].ReadClass<T>(id);
        }

        public static List<T> GetObjects<T>() where T : DofusData
        {
            String name = typeof(T).Name;
            if (!Accessors.ContainsKey(name))
            {
                Accessors[name] = new GameDataFileAccessor(DataFiles[name + "s"]);
            }
            return Accessors[name].ReadAllClass<T>();
        }
        //#region Public methode

        //public RaidBot.Protocol.DataCenter.IData GetObject(GameDataClassEnum name, int index)
        //{
        //    if (File.Exists(name + ".d2o"))
        //    {
        //        GameDataFileAccessor accesor = new GameDataFileAccessor(GameDataParam.Default.GameDataFolderPath + name.ToString() + ".d2o", new D2I.I18nFileAccessor(GameDataParam.Default.I18nFilePath));
        //        return (RaidBot.Protocol.DataCenter.IData)accesor.ReadClass(index);
        //    }
        //    else
        //        throw new Exception("Unkown data class file");
        //}

        //public RaidBot.Protocol.DataCenter.IData[] GetObjects(GameDataClassEnum name)
        //{
        //    GameDataFileAccessor accesor = new GameDataFileAccessor(GameDataParam.Default.GameDataFolderPath + name.ToString() + ".d2o", new D2I.I18nFileAccessor(GameDataParam.Default.I18nFilePath));
        //    return (RaidBot.Protocol.DataCenter.IData)accesor.ReadAllClass().ToArray();


        //#endregion // ToDo
    }
    }
