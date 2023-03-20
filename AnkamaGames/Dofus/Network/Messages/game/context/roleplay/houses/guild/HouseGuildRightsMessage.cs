


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HouseGuildRightsMessage : Dofus2Message
{

public const uint Id = 8887;
public override uint MessageId
{
    get { return Id; }
}

public uint houseId;
        public int instanceId;
        public bool secondHand;
        public Types.GuildInformations guildInfo;
        public uint rights;
        

public HouseGuildRightsMessage()
{
}

public HouseGuildRightsMessage(uint houseId, int instanceId, bool secondHand, Types.GuildInformations guildInfo, uint rights)
        {
            this.houseId = houseId;
            this.instanceId = instanceId;
            this.secondHand = secondHand;
            this.guildInfo = guildInfo;
            this.rights = rights;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)houseId);
            writer.WriteInt(instanceId);
            writer.WriteBoolean(secondHand);
            guildInfo.Serialize(writer);
            writer.WriteVarInt((int)rights);
            

}

public override void Deserialize(IDataReader reader)
{

houseId = reader.ReadVarUhInt();
            instanceId = reader.ReadInt();
            secondHand = reader.ReadBoolean();
            guildInfo = new Types.GuildInformations();
            guildInfo.Deserialize(reader);
            rights = reader.ReadVarUhInt();
            

}


}


}