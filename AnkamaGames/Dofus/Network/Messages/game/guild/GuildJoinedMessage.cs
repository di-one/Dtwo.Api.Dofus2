


















// Generated on 01/22/2023 17:42:53
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildJoinedMessage : Dofus2Message
{

public const uint Id = 630;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildInformations guildInfo;
        public uint rankId;
        

public GuildJoinedMessage()
{
}

public GuildJoinedMessage(Types.GuildInformations guildInfo, uint rankId)
        {
            this.guildInfo = guildInfo;
            this.rankId = rankId;
        }
        

public override void Serialize(IDataWriter writer)
{

guildInfo.Serialize(writer);
            writer.WriteVarInt((int)rankId);
            

}

public override void Deserialize(IDataReader reader)
{

guildInfo = new Types.GuildInformations();
            guildInfo.Deserialize(reader);
            rankId = reader.ReadVarUhInt();
            

}


}


}