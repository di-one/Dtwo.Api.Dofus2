using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Dtwo.API.Dofus2.AnkamaGames.Jerakine.Resources.Adapters
{
    public class BitmapLoaderAdaptater : LoaderAdaptaterBase
    {
        public override void LoadFromData(string path, string subPath, string outPath, byte[] data)
        {
            if (File.Exists($"{outPath}/{subPath}"))
                return;

            //using (Image image = Image.FromStream(new MemoryStream(data)))
            //{
            //    image.Save($"{outPath}/{subPath}", ImageFormat.Png);
            //}
        }
    }
}
