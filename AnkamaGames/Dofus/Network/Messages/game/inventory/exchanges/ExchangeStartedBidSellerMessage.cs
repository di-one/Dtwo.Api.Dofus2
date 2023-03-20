


















// Generated on 01/22/2023 17:42:57
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeStartedBidSellerMessage : Dofus2Message
{

public const uint Id = 3968;
public override uint MessageId
{
    get { return Id; }
}

public Types.SellerBuyerDescriptor sellerDescriptor;
        public Types.ObjectItemToSellInBid[] objectsInfos;
        

public ExchangeStartedBidSellerMessage()
{
}

public ExchangeStartedBidSellerMessage(Types.SellerBuyerDescriptor sellerDescriptor, Types.ObjectItemToSellInBid[] objectsInfos)
        {
            this.sellerDescriptor = sellerDescriptor;
            this.objectsInfos = objectsInfos;
        }
        

public override void Serialize(IDataWriter writer)
{

sellerDescriptor.Serialize(writer);
            writer.WriteShort((short)objectsInfos.Length);
            foreach (var entry in objectsInfos)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

sellerDescriptor = new Types.SellerBuyerDescriptor();
            sellerDescriptor.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            objectsInfos = new Types.ObjectItemToSellInBid[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectsInfos[i] = new Types.ObjectItemToSellInBid();
                 objectsInfos[i].Deserialize(reader);
            }
            

}


}


}