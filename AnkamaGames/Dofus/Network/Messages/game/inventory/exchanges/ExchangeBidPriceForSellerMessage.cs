


















// Generated on 01/22/2023 17:42:56
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeBidPriceForSellerMessage : ExchangeBidPriceMessage
{

public const uint Id = 9690;
public override uint MessageId
{
    get { return Id; }
}

public bool allIdentical;
        public double[] minimalPrices;
        

public ExchangeBidPriceForSellerMessage()
{
}

public ExchangeBidPriceForSellerMessage(uint genericId, double averagePrice, bool allIdentical, double[] minimalPrices)
         : base(genericId, averagePrice)
        {
            this.allIdentical = allIdentical;
            this.minimalPrices = minimalPrices;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(allIdentical);
            writer.WriteShort((short)minimalPrices.Length);
            foreach (var entry in minimalPrices)
            {
                 writer.WriteVarLong(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            allIdentical = reader.ReadBoolean();
            var limit = (ushort)reader.ReadUShort();
            minimalPrices = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 minimalPrices[i] = reader.ReadVarUhLong();
            }
            

}


}


}