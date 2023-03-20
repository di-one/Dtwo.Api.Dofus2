

















// Generated on 01/23/2023 12:54:03
using System;
using System.Collections.Generic;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.AnkamaGames.Jerakine.Data;
using Dtwo.API.DofusBase.Data;

namespace Dtwo.API.Dofus2.AnkamaGames.Dofus.DataCenter
{

public class SpellLevel : DofusData
{

public const String MODULE = "SpellLevels";
        public uint id;
        public uint spellId;
        public uint grade;
        public uint spellBreed;
        public uint apCost;
        public uint minRange;
        public uint range;
        public Boolean castInLine;
        public Boolean castInDiagonal;
        public Boolean castTestLos;
        public uint criticalHitProbability;
        public Boolean needFreeCell;
        public Boolean needTakenCell;
        public Boolean needFreeTrapCell;
        public Boolean needVisibleEntity;
        public Boolean needCellWithoutPortal;
        public Boolean portalProjectionForbidden;
        public Boolean rangeCanBeBoosted;
        public int maxStack;
        public uint maxCastPerTurn;
        public uint maxCastPerTarget;
        public uint minCastInterval;
        public uint initialCooldown;
        public int globalCooldown;
        public uint minPlayerLevel;
        public Boolean hideEffects;
        public Boolean hidden;
        public Boolean playAnimation;
        public String statesCriterion;
        public List<EffectInstanceDice> effects;
        public List<EffectInstanceDice> criticalEffect;
        public List<EffectZone> previewZones;
        

}

}