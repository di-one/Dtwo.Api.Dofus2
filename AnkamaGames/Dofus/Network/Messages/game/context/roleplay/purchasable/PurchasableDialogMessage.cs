


















// Generated on 01/22/2023 17:42:50
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PurchasableDialogMessage : Dofus2Message
{

public const uint Id = 4765;
public override uint MessageId
{
    get { return Id; }
}

public bool buyOrSell;
        public bool secondHand;
        public double purchasableId;
        public int purchasableInstanceId;
        public double price;
        

public PurchasableDialogMessage()
{
}

public PurchasableDialogMessage(bool buyOrSell, bool secondHand, double purchasableId, int purchasableInstanceId, double price)
        {
            this.buyOrSell = buyOrSell;
            this.secondHand = secondHand;
            this.purchasableId = purchasableId;
            this.purchasableInstanceId = purchasableInstanceId;
            this.price = price;
        }
        

public override void Serialize(IDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, buyOrSell);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, secondHand);
            writer.WriteByte(flag1);
            writer.WriteDouble(purchasableId);
            writer.WriteInt(purchasableInstanceId);
            writer.WriteVarLong(price);
            

}

public override void Deserialize(IDataReader reader)
{

byte flag1 = reader.ReadByte();
            buyOrSell = BooleanByteWrapper.GetFlag(flag1, 0);
            secondHand = BooleanByteWrapper.GetFlag(flag1, 1);
            purchasableId = reader.ReadDouble();
            purchasableInstanceId = reader.ReadInt();
            price = reader.ReadVarUhLong();
            

}


}


}