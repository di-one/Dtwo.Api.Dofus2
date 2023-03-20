


















// Generated on 01/22/2023 17:42:56
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeCraftPaymentModifiedMessage : Dofus2Message
{

public const uint Id = 9672;
public override uint MessageId
{
    get { return Id; }
}

public double goldSum;
        

public ExchangeCraftPaymentModifiedMessage()
{
}

public ExchangeCraftPaymentModifiedMessage(double goldSum)
        {
            this.goldSum = goldSum;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(goldSum);
            

}

public override void Deserialize(IDataReader reader)
{

goldSum = reader.ReadVarUhLong();
            

}


}


}