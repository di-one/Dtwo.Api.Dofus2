


















// Generated on 01/22/2023 17:42:53
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildInAllianceFactsMessage : GuildFactsMessage
{

public const uint Id = 4511;
public override uint MessageId
{
    get { return Id; }
}

public Types.BasicNamedAllianceInformations allianceInfos;
        

public GuildInAllianceFactsMessage()
{
}

public GuildInAllianceFactsMessage(Types.GuildFactSheetInformations infos, int creationDate, uint nbTaxCollectors, Types.CharacterMinimalGuildPublicInformations[] members, Types.BasicNamedAllianceInformations allianceInfos)
         : base(infos, creationDate, nbTaxCollectors, members)
        {
            this.allianceInfos = allianceInfos;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            allianceInfos.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            allianceInfos = new Types.BasicNamedAllianceInformations();
            allianceInfos.Deserialize(reader);
            

}


}


}