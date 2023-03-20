


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HouseSellingUpdateMessage : Dofus2Message
{

public const uint Id = 2570;
public override uint MessageId
{
    get { return Id; }
}

public uint houseId;
        public int instanceId;
        public bool secondHand;
        public double realPrice;
        public Types.AccountTagInformation buyerTag;
        

public HouseSellingUpdateMessage()
{
}

public HouseSellingUpdateMessage(uint houseId, int instanceId, bool secondHand, double realPrice, Types.AccountTagInformation buyerTag)
        {
            this.houseId = houseId;
            this.instanceId = instanceId;
            this.secondHand = secondHand;
            this.realPrice = realPrice;
            this.buyerTag = buyerTag;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)houseId);
            writer.WriteInt(instanceId);
            writer.WriteBoolean(secondHand);
            writer.WriteVarLong(realPrice);
            buyerTag.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

houseId = reader.ReadVarUhInt();
            instanceId = reader.ReadInt();
            secondHand = reader.ReadBoolean();
            realPrice = reader.ReadVarUhLong();
            buyerTag = new Types.AccountTagInformation();
            buyerTag.Deserialize(reader);
            

}


}


}