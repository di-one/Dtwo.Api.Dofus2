


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HouseGuildShareRequestMessage : Dofus2Message
{

public const uint Id = 6884;
public override uint MessageId
{
    get { return Id; }
}

public uint houseId;
        public int instanceId;
        public bool enable;
        public uint rights;
        

public HouseGuildShareRequestMessage()
{
}

public HouseGuildShareRequestMessage(uint houseId, int instanceId, bool enable, uint rights)
        {
            this.houseId = houseId;
            this.instanceId = instanceId;
            this.enable = enable;
            this.rights = rights;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)houseId);
            writer.WriteInt(instanceId);
            writer.WriteBoolean(enable);
            writer.WriteVarInt((int)rights);
            

}

public override void Deserialize(IDataReader reader)
{

houseId = reader.ReadVarUhInt();
            instanceId = reader.ReadInt();
            enable = reader.ReadBoolean();
            rights = reader.ReadVarUhInt();
            

}


}


}