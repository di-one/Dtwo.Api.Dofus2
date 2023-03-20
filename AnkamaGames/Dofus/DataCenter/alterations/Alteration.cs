

















// Generated on 01/23/2023 12:53:59
using System;
using System.Collections.Generic;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.AnkamaGames.Jerakine.Data;
using Dtwo.API.DofusBase.Data;

namespace Dtwo.API.Dofus2.AnkamaGames.Dofus.DataCenter
{

public class Alteration : DofusData
{

public const String MODULE = "Alterations";
        public uint id;
        public uint nameId;
        public uint descriptionId;
        public uint categoryId;
        public int iconId;
        public Boolean isVisible;
        public String criteria;
        public Boolean isWebDisplay;
        public List<EffectInstance> possibleEffects = null;
        

}

}