

















// Generated on 01/23/2023 12:54:02
using System;
using System.Collections.Generic;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.AnkamaGames.Jerakine.Data;
using Dtwo.API.DofusBase.Data;

namespace Dtwo.API.Dofus2.AnkamaGames.Dofus.DataCenter
{

public class MonsterRace : DofusData
{

public const String MODULE = "MonsterRaces";
        public int id;
        public int superRaceId;
        public uint nameId;
        public List<uint> monsters;
        public int aggressiveZoneSize;
        public int aggressiveLevelDiff;
        public String aggressiveImmunityCriterion;
        public int aggressiveAttackDelay;
        

}

}