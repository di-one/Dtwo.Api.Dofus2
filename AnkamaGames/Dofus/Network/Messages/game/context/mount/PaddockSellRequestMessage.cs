


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PaddockSellRequestMessage : Dofus2Message
{

public const uint Id = 1652;
public override uint MessageId
{
    get { return Id; }
}

public double price;
        public bool forSale;
        

public PaddockSellRequestMessage()
{
}

public PaddockSellRequestMessage(double price, bool forSale)
        {
            this.price = price;
            this.forSale = forSale;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(price);
            writer.WriteBoolean(forSale);
            

}

public override void Deserialize(IDataReader reader)
{

price = reader.ReadVarUhLong();
            forSale = reader.ReadBoolean();
            

}


}


}