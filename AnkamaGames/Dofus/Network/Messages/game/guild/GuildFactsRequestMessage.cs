


















// Generated on 01/22/2023 17:42:52
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildFactsRequestMessage : Dofus2Message
{

public const uint Id = 1622;
public override uint MessageId
{
    get { return Id; }
}

public uint guildId;
        

public GuildFactsRequestMessage()
{
}

public GuildFactsRequestMessage(uint guildId)
        {
            this.guildId = guildId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)guildId);
            

}

public override void Deserialize(IDataReader reader)
{

guildId = reader.ReadVarUhInt();
            

}


}


}