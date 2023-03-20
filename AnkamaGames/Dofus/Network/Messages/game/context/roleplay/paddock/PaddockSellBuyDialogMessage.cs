


















// Generated on 01/22/2023 17:42:48
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PaddockSellBuyDialogMessage : Dofus2Message
{

public const uint Id = 6699;
public override uint MessageId
{
    get { return Id; }
}

public bool bsell;
        public uint ownerId;
        public double price;
        

public PaddockSellBuyDialogMessage()
{
}

public PaddockSellBuyDialogMessage(bool bsell, uint ownerId, double price)
        {
            this.bsell = bsell;
            this.ownerId = ownerId;
            this.price = price;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(bsell);
            writer.WriteVarInt((int)ownerId);
            writer.WriteVarLong(price);
            

}

public override void Deserialize(IDataReader reader)
{

bsell = reader.ReadBoolean();
            ownerId = reader.ReadVarUhInt();
            price = reader.ReadVarUhLong();
            

}


}


}