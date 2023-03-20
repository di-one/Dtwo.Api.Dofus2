


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildApplicationIsAnsweredMessage : Dofus2Message
{

public const uint Id = 507;
public override uint MessageId
{
    get { return Id; }
}

public bool accepted;
        public Types.GuildInformations guildInformation;
        

public GuildApplicationIsAnsweredMessage()
{
}

public GuildApplicationIsAnsweredMessage(bool accepted, Types.GuildInformations guildInformation)
        {
            this.accepted = accepted;
            this.guildInformation = guildInformation;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(accepted);
            guildInformation.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

accepted = reader.ReadBoolean();
            guildInformation = new Types.GuildInformations();
            guildInformation.Deserialize(reader);
            

}


}


}