


















// Generated on 01/22/2023 17:42:53
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildModificationEmblemValidMessage : Dofus2Message
{

public const uint Id = 5538;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildEmblem guildEmblem;
        

public GuildModificationEmblemValidMessage()
{
}

public GuildModificationEmblemValidMessage(Types.GuildEmblem guildEmblem)
        {
            this.guildEmblem = guildEmblem;
        }
        

public override void Serialize(IDataWriter writer)
{

guildEmblem.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

guildEmblem = new Types.GuildEmblem();
            guildEmblem.Deserialize(reader);
            

}


}


}