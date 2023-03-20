

















// Generated on 01/23/2023 12:54:02
using System;
using System.Collections.Generic;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.AnkamaGames.Jerakine.Data;
using Dtwo.API.DofusBase.Data;

namespace Dtwo.API.Dofus2.AnkamaGames.Dofus.DataCenter
{

public class Skill : DofusData
{

public const String MODULE = "Skills";
        public int id;
        public uint nameId;
        public int parentJobId;
        public Boolean isForgemagus;
        public List<int> modifiableItemTypeIds;
        public int gatheredRessourceItem;
        public List<int> craftableItemIds;
        public int interactiveId;
        public int range;
        public Boolean useRangeInClient;
        public String useAnimation;
        public int cursor;
        public int elementActionId;
        public Boolean availableInHouse;
        public uint levelMin;
        public Boolean clientDisplay;
        

}

}