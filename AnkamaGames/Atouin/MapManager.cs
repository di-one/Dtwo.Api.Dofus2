using System.IO.Compression;
using Dtwo.API.Dofus2.AnkamaGames.Jerakine.Resources.Protocols;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Atouin
{
    public class MapManager
    {
        public static List<Dictionary<string, PakIndex>> m_mapsPak = new List<Dictionary<string, PakIndex>>();

        public static void Init(string mapsPath)
        {
            var files = Directory.GetFiles(mapsPath);
            foreach (var file in files)
            {
                if (Path.GetExtension(file) != ".d2p")
                    continue;

                var pak = PakProtocol2.GetFilesIndex(file);

                if (pak == null)
                {
                    //LogManager.LogWarning($"pak of {file} is null");
                    return;
                }

                m_mapsPak.Add(pak);
                
                //foreach(var p in m_mapsPak.Last())
                //{
                //    LogManager.Log("register d2p map : " + p.Key);
                //}
            }
        }

        public static MapData LoadFromPath(string path)
        {
            byte[] mapBytes = GetMapBytes(path);
            if (mapBytes != null)
            {
                MemoryStream stream = new MemoryStream(mapBytes) { Position = 2 };
                DeflateStream stream2 = new DeflateStream(stream, CompressionMode.Decompress);
                byte[] buffer = new byte[8192];
                MemoryStream destination = new MemoryStream();
                int read;
                while ((read = stream2.Read(buffer, 0, buffer.Length)) > 0)
                {
                    destination.Write(buffer, 0, read);
                }
                destination.Position = 0;
                BigEndianReader reader = new BigEndianReader(destination);
                MapData map = new MapData();
                map.Init(reader);
                Array.Clear(mapBytes, 0, mapBytes.Length);

                return map;
            }
            else
            {
                LogManager.LogWarning("map byte == null");
            }

            return null;
        }

        public static MapData LoadFromId(double id)
        {
            LogManager.Log("Get map " + id);

            string str = ((id % 10).ToString() + "/" + id.ToString() + ".dlm");

            return LoadFromPath(str);
        }

        private static byte[] GetMapBytes(string name)
        {
            for (int i = 0; i < m_mapsPak.Count; i++)
            {
                var dicPak = m_mapsPak[i];

                PakIndex pak = null;
                if (dicPak.TryGetValue(name, out pak) == false)
                {
                    continue;
                }

                return GetMapBytes(pak);
            }

            return null;
        }

        private static byte[] GetMapBytes(PakIndex pak)
        {
            BigEndianReader reader = new BigEndianReader(pak.Stream);
            reader.BaseStream.Position = pak.FileOffset;

            return reader.ReadBytes(pak.FileLenght);
        }
    }
}
