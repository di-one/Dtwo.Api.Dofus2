

















// Generated on 01/23/2023 12:54:00
using System;
using System.Collections.Generic;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.AnkamaGames.Jerakine.Data;
using Dtwo.API.DofusBase.Data;

namespace Dtwo.API.Dofus2.AnkamaGames.Dofus.DataCenter
{

public class Challenge : DofusData
{

public const String MODULE = "Challenges";
        public int id;
        public uint nameId;
        public uint descriptionId;
        public List<uint> incompatibleChallenges;
        public int categoryId;
        public int iconId;
        public String activationCriterion;
        public String completionCriterion;
        public uint targetMonsterId;
        

}

}