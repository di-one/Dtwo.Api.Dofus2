


















// Generated on 01/22/2023 17:42:58
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeStartOkNpcTradeMessage : Dofus2Message
{

public const uint Id = 8770;
public override uint MessageId
{
    get { return Id; }
}

public double npcId;
        

public ExchangeStartOkNpcTradeMessage()
{
}

public ExchangeStartOkNpcTradeMessage(double npcId)
        {
            this.npcId = npcId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(npcId);
            

}

public override void Deserialize(IDataReader reader)
{

npcId = reader.ReadDouble();
            

}


}


}