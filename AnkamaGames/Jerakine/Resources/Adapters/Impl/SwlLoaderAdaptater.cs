using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Jerakine.Resources.Adapters
{
    public class SwlLoaderAdaptater : LoaderAdaptaterBase
    {
        public override void LoadFromData(string path, string subPath, string outPath, byte[] data)
        {
            string fsPath = $"{outPath}/{subPath.Replace(".swl", ".swf")}";

            if (File.Exists(fsPath))
                return;

            using (FileStream fs = new FileStream(fsPath, FileMode.CreateNew, FileAccess.Write))
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    BigEndianReader reader = new BigEndianReader(ms);

                    var file = reader.ReadByte();
                    var version = reader.ReadByte();
                    var frameRate = reader.ReadUInt();
                    var classCount = reader.ReadInt();

                    for (int i = 0; i < classCount; i++)
                    {
                        reader.ReadUTF();
                    }

                    reader.BaseStream.CopyTo(fs);
                }
            }
        }
    }
}
