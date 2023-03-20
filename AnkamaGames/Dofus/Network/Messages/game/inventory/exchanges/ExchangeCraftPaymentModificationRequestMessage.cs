


















// Generated on 01/22/2023 17:42:56
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeCraftPaymentModificationRequestMessage : Dofus2Message
{

public const uint Id = 1214;
public override uint MessageId
{
    get { return Id; }
}

public double quantity;
        

public ExchangeCraftPaymentModificationRequestMessage()
{
}

public ExchangeCraftPaymentModificationRequestMessage(double quantity)
        {
            this.quantity = quantity;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(quantity);
            

}

public override void Deserialize(IDataReader reader)
{

quantity = reader.ReadVarUhLong();
            

}


}


}