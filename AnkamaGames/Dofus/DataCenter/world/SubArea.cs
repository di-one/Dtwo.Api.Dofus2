

















// Generated on 01/23/2023 12:54:03
using System;
using System.Collections.Generic;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.AnkamaGames.Jerakine.Data;
using Dtwo.API.DofusBase.Data;

namespace Dtwo.API.Dofus2.AnkamaGames.Dofus.DataCenter
{

public class SubArea : DofusData
{

public const String MODULE = "SubAreas";
        public int id;
        public uint nameId;
        public int areaId;
        public List<List<int>> playlists;
        public List<double> mapIds;
        public Object bounds;
        public List<int> shape;
        public int worldmapId;
        public List<uint> customWorldMap;
        public int packId;
        public uint level;
        public Boolean isConquestVillage;
        public Boolean basicAccountAllowed;
        public Boolean displayOnWorldMap;
        public Boolean mountAutoTripAllowed;
        public Boolean psiAllowed;
        public List<uint> monsters;
        public Boolean capturable;
        public List<List<double>> quests;
        public List<List<double>> npcs;
        public List<int> harvestables;
        public int associatedZaapMapId;
        

}

}