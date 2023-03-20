

















// Generated on 01/23/2023 12:54:02
using System;
using System.Collections.Generic;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.AnkamaGames.Jerakine.Data;
using Dtwo.API.DofusBase.Data;

namespace Dtwo.API.Dofus2.AnkamaGames.Dofus.DataCenter
{

public class PopupInformation : DofusData
{

public const String MODULE = "PopupInformations";
        public int id;
        public uint parentId;
        public uint titleId;
        public uint descriptionId;
        public String illuName;
        public List<PopupButton> buttons;
        public String criterion;
        public uint cacheType;
        public Boolean autoTrigger;
        

}

}