using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dtwo.API.DofusBase.Data;

namespace Dtwo.API.Dofus2.AnkamaGames.Dofus.DataCenter
{
    public class TransformData : DofusData
    {
        public string overrideClip;

        public string originalClip;

        public double x;

        public double y;

        public double scaleX = 1.0;

        public double scaleY = 1.0;

        public double rotation = 0.0;
    }
}
