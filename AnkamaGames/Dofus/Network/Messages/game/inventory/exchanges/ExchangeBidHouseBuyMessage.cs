


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeBidHouseBuyMessage : Dofus2Message
{

public const uint Id = 5543;
public override uint MessageId
{
    get { return Id; }
}

public uint uid;
        public uint qty;
        public double price;
        

public ExchangeBidHouseBuyMessage()
{
}

public ExchangeBidHouseBuyMessage(uint uid, uint qty, double price)
        {
            this.uid = uid;
            this.qty = qty;
            this.price = price;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)uid);
            writer.WriteVarInt((int)qty);
            writer.WriteVarLong(price);
            

}

public override void Deserialize(IDataReader reader)
{

uid = reader.ReadVarUhInt();
            qty = reader.ReadVarUhInt();
            price = reader.ReadVarUhLong();
            

}


}


}