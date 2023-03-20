


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HouseBuyResultMessage : Dofus2Message
{

public const uint Id = 3504;
public override uint MessageId
{
    get { return Id; }
}

public bool secondHand;
        public bool bought;
        public uint houseId;
        public int instanceId;
        public double realPrice;
        

public HouseBuyResultMessage()
{
}

public HouseBuyResultMessage(bool secondHand, bool bought, uint houseId, int instanceId, double realPrice)
        {
            this.secondHand = secondHand;
            this.bought = bought;
            this.houseId = houseId;
            this.instanceId = instanceId;
            this.realPrice = realPrice;
        }
        

public override void Serialize(IDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, secondHand);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, bought);
            writer.WriteByte(flag1);
            writer.WriteVarInt((int)houseId);
            writer.WriteInt(instanceId);
            writer.WriteVarLong(realPrice);
            

}

public override void Deserialize(IDataReader reader)
{

byte flag1 = reader.ReadByte();
            secondHand = BooleanByteWrapper.GetFlag(flag1, 0);
            bought = BooleanByteWrapper.GetFlag(flag1, 1);
            houseId = reader.ReadVarUhInt();
            instanceId = reader.ReadInt();
            realPrice = reader.ReadVarUhLong();
            

}


}


}