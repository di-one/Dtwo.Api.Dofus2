using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.Dofus2
{
    public class Paths
    {
        public static readonly string ConfigPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "d2paths.json");
        public static PathsConfiguration Config { get; private set; }
        public static string DofusBasePath { get; private set; }
        public static string DofusContentPath { get; private set; }
        public static string DofusAudioPath { get; private set; }
        public static string DofusMapsPath { get; private set; }
        public static string DofusDataPath { get; private set; }
        public static string DofusBindsPath { get; private set; }
        public static string DofusI18NPath { get; private set; }
        public static string DofusCommonPath { get; private set; }

        public static void Init()
        {
            if (LoadConfig())
            {
                InitPaths();
            }
        }

        private static bool LoadConfig()
        {
            if (File.Exists(ConfigPath) == false)
            {
                Config = new PathsConfiguration();
                SaveConfig(true);

                return false;
            }
            else
            {
                Config = Json.JSonSerializer<PathsConfiguration>.DeSerialize(File.ReadAllText(ConfigPath));

                return true;
            }
        }

        public static void SaveConfig(bool force = false)
        {
            File.WriteAllText(ConfigPath, Json.JSonSerializer<PathsConfiguration>.Serialize(Config));
            InitPaths();

            if (force == false)
            {
                LogManager.Log("Paths configuration sauvegardée", 1);
            }
        }

        private static void InitPaths()
        {
            DofusBasePath = Config.DofusBasePath;
            DofusContentPath = Path.Combine(DofusBasePath, Config.DofusContentBasePath);
            DofusAudioPath = Path.Combine(DofusContentPath, Config.DofusContentAudioBasePath);
            DofusMapsPath = Path.Combine(DofusContentPath, Config.DofusContentMapsBasePath);

            DofusDataPath = Path.Combine(DofusBasePath, Config.DofusDataBasePath);
            DofusBindsPath = Path.Combine(DofusDataPath, Config.DofusDataBindsBasePath);
            DofusI18NPath = Path.Combine(DofusDataPath, Config.DofusDataI18NBasePath);
            DofusCommonPath = Path.Combine(DofusDataPath, Config.DofusDataCommonBasePath);
        }
    }
}
