


















// Generated on 01/22/2023 17:42:58
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeStartOkRecycleTradeMessage : Dofus2Message
{

public const uint Id = 6135;
public override uint MessageId
{
    get { return Id; }
}

public short percentToPrism;
        public short percentToPlayer;
        

public ExchangeStartOkRecycleTradeMessage()
{
}

public ExchangeStartOkRecycleTradeMessage(short percentToPrism, short percentToPlayer)
        {
            this.percentToPrism = percentToPrism;
            this.percentToPlayer = percentToPlayer;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(percentToPrism);
            writer.WriteShort(percentToPlayer);
            

}

public override void Deserialize(IDataReader reader)
{

percentToPrism = reader.ReadShort();
            percentToPlayer = reader.ReadShort();
            

}


}


}