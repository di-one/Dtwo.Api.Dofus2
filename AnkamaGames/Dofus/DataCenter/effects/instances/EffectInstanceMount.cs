

















// Generated on 01/23/2023 12:54:00
using System;
using System.Collections.Generic;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.AnkamaGames.Jerakine.Data;
using Dtwo.API.DofusBase.Data;

namespace Dtwo.API.Dofus2.AnkamaGames.Dofus.DataCenter
{

public class EffectInstanceMount : EffectInstance
{

public double id;
        public double expirationDate;
        public uint model;
        public String name = "";
        public String owner = "";
        public uint level = 0;
        public Boolean sex = false;
        public Boolean isRideable = false;
        public Boolean isFeconded = false;
        public Boolean isFecondationReady = false;
        public int reproductionCount = 0;
        public uint reproductionCountMax = 0;
        public List<EffectInstanceInteger> effects;
        public List<uint> capacities;
        

}

}