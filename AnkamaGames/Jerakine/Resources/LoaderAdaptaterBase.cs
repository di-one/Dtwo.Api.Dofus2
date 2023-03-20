using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.Dofus2.AnkamaGames.Jerakine.Resources
{
    public abstract class LoaderAdaptaterBase
    {
        public abstract void LoadFromData(string path, string subPath, string outPath, byte[] data);
    }
}
