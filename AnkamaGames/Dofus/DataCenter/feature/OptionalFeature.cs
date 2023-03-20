

















// Generated on 01/23/2023 12:54:00
using System;
using System.Collections.Generic;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.AnkamaGames.Jerakine.Data;
using Dtwo.API.DofusBase.Data;

namespace Dtwo.API.Dofus2.AnkamaGames.Dofus.DataCenter
{

public class OptionalFeature : DofusData
{

public const String MODULE = "OptionalFeatures";
        public int id;
        public String keyword;
        public Boolean isClient;
        public Boolean isServer;
        public Boolean isActivationOnLaunch = false;
        public Boolean isActivationOnServerConnection = false;
        public String activationCriterions = null;
        

}

}