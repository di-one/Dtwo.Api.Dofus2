

















// Generated on 01/23/2023 12:54:03
using System;
using System.Collections.Generic;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.AnkamaGames.Jerakine.Data;
using Dtwo.API.DofusBase.Data;

namespace Dtwo.API.Dofus2.AnkamaGames.Dofus.DataCenter
{

public class WorldMap : DofusData
{

public const String MODULE = "WorldMaps";
        public int id;
        public uint nameId;
        public int origineX;
        public int origineY;
        public double mapWidth;
        public double mapHeight;
        public Boolean viewableEverywhere;
        public double minScale;
        public double maxScale;
        public double startScale;
        public int totalWidth;
        public int totalHeight;
        public List<String> zoom;
        public Boolean visibleOnMap;
        

}

}