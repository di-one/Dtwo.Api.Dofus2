


















// Generated on 01/22/2023 17:42:56
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeBidPriceMessage : Dofus2Message
{

public const uint Id = 1265;
public override uint MessageId
{
    get { return Id; }
}

public uint genericId;
        public double averagePrice;
        

public ExchangeBidPriceMessage()
{
}

public ExchangeBidPriceMessage(uint genericId, double averagePrice)
        {
            this.genericId = genericId;
            this.averagePrice = averagePrice;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)genericId);
            writer.WriteVarLong(averagePrice);
            

}

public override void Deserialize(IDataReader reader)
{

genericId = reader.ReadVarUhInt();
            averagePrice = reader.ReadVarLong();
            

}


}


}