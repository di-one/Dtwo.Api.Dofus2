


















// Generated on 01/22/2023 17:42:57
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeObjectMoveKamaMessage : Dofus2Message
{

public const uint Id = 1808;
public override uint MessageId
{
    get { return Id; }
}

public double quantity;
        

public ExchangeObjectMoveKamaMessage()
{
}

public ExchangeObjectMoveKamaMessage(double quantity)
        {
            this.quantity = quantity;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(quantity);
            

}

public override void Deserialize(IDataReader reader)
{

quantity = reader.ReadVarLong();
            

}


}


}