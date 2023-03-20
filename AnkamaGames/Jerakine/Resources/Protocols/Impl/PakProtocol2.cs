using Dtwo.API.Dofus2.AnkamaGames.Jerakine.Resources.Adapters;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Jerakine.Resources.Protocols
{
    public class PakProtocol2
    {
        private static Dictionary<string, Dictionary<string, PakIndex>> _indexes = new Dictionary<string, Dictionary<string, PakIndex>>();
        private static Dictionary<string, Dictionary<string, string>> _properties = new Dictionary<string, Dictionary<string, string>>();

        public PakProtocol2()
        {
        }

        public static Dictionary<string, PakIndex> GetFilesIndex(string path)
        {
            if (_indexes.ContainsKey(path) == false)
            {
                var fileStream = InitStream(path);
                if (fileStream == null)
                {
                    return null;
                }
            }

            return _indexes[path];
        }

        public static void LoadFolders(string path, string outPath)
        {
            var directories = Directory.GetDirectories(path);

            foreach (var d in directories)
            {
                DirectoryInfo directory = new DirectoryInfo(d);
                string subFolderPath = Path.Combine(outPath, directory.Name);

                if (Directory.Exists(subFolderPath) == false)
                {
                    Directory.CreateDirectory(subFolderPath);
                }

                LoadFolder(d, subFolderPath);
            }
        }

        public static void LoadFolder(string path, string outPath)
        {
            Console.WriteLine($"Load {path} d2p's");

            var d2pFiles = Directory.GetFiles(path);
            int filesLoaded = 0;
            int filesWrited = 0;

            foreach (var d2pFile in d2pFiles)
            {
                if (Path.GetExtension(d2pFile).ToLower() != ".d2p")
                {
                    continue;
                }

                var files = GetFilesIndex(d2pFile);

                if (files == null)
                {
                    Console.WriteLine("Error: files is null " + d2pFile);
                    continue;
                }

                foreach (var file in files)
                {
                    var adaptater = GetAdaptater(file.Key);

                    if (adaptater == null)
                    {
                        continue;
                    }

                    PakProtocol2.Load(d2pFile, file.Key, outPath, adaptater);
                    filesWrited++;
                }

                filesLoaded++;
            }

            Console.WriteLine("-- Loaded files : " + filesLoaded + " Writted files : " + filesWrited);

        }

        private static LoaderAdaptaterBase GetAdaptater(string fileName)
        {
            string ext = Path.GetExtension(fileName);

            switch(ext.ToLower())
            {
                case ".swl":
                    return new SwlLoaderAdaptater();
                case ".png":
                    return new BitmapLoaderAdaptater();
            }

            Console.WriteLine($"Not adapter found for {ext} extension");
            return null;
        }

        public static void Load(string path, string subPath, string outPath, LoaderAdaptaterBase forcedAdapter)
        {
            if (File.Exists(outPath))
                return;


            if (subPath.Contains("/"))
            {
                string subPathFolderPath = Path.Combine(outPath, Path.GetDirectoryName(subPath));

                //Console.WriteLine("______________________ " + subPathFolderPath);

                if (Directory.Exists(subPathFolderPath) == false)
                {
                    Directory.CreateDirectory(subPathFolderPath);
                }
            }



            FileStream fileStream = null;
            if (_indexes.ContainsKey(path) == false)
            {
                fileStream = InitStream(path);
                if (fileStream == null)
                {
                    return;
                }
            }

            var index = _indexes[path][subPath];

            fileStream = index.Stream;
            var data = new byte[index.FileLenght];
            fileStream.Position = index.FileOffset;
            fileStream.Read(data, 0, (int)index.FileLenght);

            try
            {
                forcedAdapter.LoadFromData(path, subPath, outPath, data);
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error : " + path + " " + subPath);
                Console.WriteLine($"Can't load byte array from this adapter {e.Message}");
                return;
            }
        }

        private static FileStream InitStream(string path)
        {
            FileStream fs = null;
            var vMax = 0;
            var vMin = 0;
            var dataOffset = 0u;
            var dataCount = 0u;
            var indexOffset = 0u;
            var indexCount = 0u;
            var propertiesOffset = 0u;
            var propertiesCount = 0u;
            string propertyName = null;
            string propertyValue = null;
            var i = 0u;
            string filePath = null;
            var fileOffset = 0;
            var fileLength = 0;
            var idx = 0;

            FileInfo file = new FileInfo(path);

            var indexes = new Dictionary<string, PakIndex>();
            var properties = new Dictionary<string, string>();
            _indexes[path] = indexes;
            _properties[path] = properties;
            while (file != null && file.Exists)
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                BigEndianReader reader = new BigEndianReader(fs);

                vMax = reader.ReadByte();
                vMin = reader.ReadByte();
                if (vMax != 2 || vMin != 1)
                {
                    return null;
                }

                fs.Position = file.Length - 24;
                dataOffset = reader.ReadUInt32();
                dataCount = reader.ReadUInt32();
                indexOffset = reader.ReadUInt32();
                indexCount = reader.ReadUInt32();
                propertiesOffset = reader.ReadUInt32();
                propertiesCount = reader.ReadUInt32();
                fs.Position = propertiesOffset;
                file = null;
                for (i = 0; i < propertiesCount; i++)
                {
                    propertyName = reader.ReadUTF();
                    propertyValue = reader.ReadUTF();
                    properties[propertyName] = propertyValue;
                    if (propertyName == "link")
                    {
                        idx = path.LastIndexOf("/");
                        if (idx != -1)
                        {
                            path = path.Substring(0, idx) + "/" + propertyValue;
                        }
                        else
                        {
                            path = propertyValue;
                        }

                        file = new FileInfo(path);
                    }
                }

                fs.Position = indexOffset;
                for (i = 0; i < indexCount; i++)
                {
                    filePath = reader.ReadUTF();
                    fileOffset = reader.ReadInt32();
                    fileLength = reader.ReadInt32();
                    indexes[filePath] = new PakIndex(fs, fileLength, fileOffset + dataOffset);
                }
            }

            return fs;
        }
    }
}