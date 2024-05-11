using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dtwo.API.Dofus2.AnkamaGames.Jerakine.Data;
using Dtwo.API.DofusBase.Data;
using RaidBot.Data.IO.D2O;

namespace Dtwo.API.Dofus2.Data
{
    public static class Database
    {
        public static T GetData<T>(int id) where T : DofusData => RaidBot.Data.IO.D2O.GameDataManager.GetObject<T>(id);
        public static List<T> GetData<T>() where T : DofusData => RaidBot.Data.IO.D2O.GameDataManager.GetObjects<T>();

        public static Dictionary<double, List<MapTeleporters>> Teleporters = new Dictionary<double, List<MapTeleporters>>();

        public static bool Init(string folderPath)
        {
            if (Directory.Exists(folderPath) == false)
            {
                LogManager.LogError($"Error on init database : The directory {folderPath} not found", 1);
                return false;
            }

            //Console.WriteLine("fodlerpath : " + folderPath);
            //var files = Directory.EnumerateFiles(folderPath);

            //RaidBot.Data.IO.D2O.GameDataFileAccessor.ReadClassDefinitions(folderPath);
            RaidBot.Data.IO.D2O.GameDataManager.Init(folderPath);

            //foreach (var file in files)
            //{
            //    try
            //    {
            //        //GameDataFileAccessor accessor = new GameDataFileAccessor();
            //        //accessor.Init(file);

            //        LogManager.Log($"Add {file} to Database");
            //    }
            //    catch (Exception ex)
            //    {
            //        LogManager.LogWarning($"Error on init database : The file {file} was not parsed correctly, see logs for few infos", 1);
            //        LogManager.LogWarning(ex.ToString());
            //    }
            //}

            return true;
        }

        public static void LoadTeleporters(string filePath)
        {
            string txt = File.ReadAllText(filePath);
            var teleporters = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MapTeleporters>>(txt);

            foreach (var m in teleporters)
            {
                if (Teleporters.ContainsKey(m.MapId) == false)
                {
                    List<MapTeleporters> tps = new List<MapTeleporters>();
                    tps.Add(m);
                    Teleporters.Add(m.MapId, tps);
                }
                else
                {
                    Teleporters[m.MapId].Add(m);
                }
            }
        }
    }
}
