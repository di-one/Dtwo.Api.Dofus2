


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HouseGuildRightsViewMessage : Dofus2Message
{

public const uint Id = 3318;
public override uint MessageId
{
    get { return Id; }
}

public uint houseId;
        public int instanceId;
        

public HouseGuildRightsViewMessage()
{
}

public HouseGuildRightsViewMessage(uint houseId, int instanceId)
        {
            this.houseId = houseId;
            this.instanceId = instanceId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)houseId);
            writer.WriteInt(instanceId);
            

}

public override void Deserialize(IDataReader reader)
{

houseId = reader.ReadVarUhInt();
            instanceId = reader.ReadInt();
            

}


}


}