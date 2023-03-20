

















// Generated on 01/23/2023 12:54:02
using System;
using System.Collections.Generic;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.AnkamaGames.Jerakine.Data;
using Dtwo.API.DofusBase.Data;

namespace Dtwo.API.Dofus2.AnkamaGames.Dofus.DataCenter
{

public class Monster : DofusData
{

public const String MODULE = "Monsters";
        public int id;
        public uint nameId;
        public uint gfxId;
        public int race;
        public List<MonsterGrade> grades;
        public String look;
        public Boolean useSummonSlot;
        public Boolean useBombSlot;
        public Boolean canPlay;
        public Boolean canTackle;
        public Boolean isBoss;
        public List<MonsterDrop> drops;
        public List<MonsterDrop> temporisDrops;
        public List<AnimFunMonsterData> animFunList;
        public List<uint> subareas;
        public List<uint> spells;
        public List<String> spellGrades;
        public int favoriteSubareaId;
        public Boolean isMiniBoss;
        public Boolean isQuestMonster;
        public uint correspondingMiniBossId;
        public double speedAdjust = 0.0;
        public int creatureBoneId;
        public Boolean canBePushed;
        public Boolean canBeCarried;
        public Boolean canUsePortal;
        public Boolean canSwitchPos;
        public Boolean canSwitchPosOnTarget;
        public Boolean fastAnimsFun;
        public List<uint> incompatibleIdols;
        public Boolean allIdolsDisabled;
        public List<uint> incompatibleChallenges;
        public Boolean useRaceValues;
        public int aggressiveZoneSize;
        public int aggressiveLevelDiff;
        public String aggressiveImmunityCriterion;
        public int aggressiveAttackDelay;
        public int scaleGradeRef;
        public List<List<double>> characRatios;
        

}

}