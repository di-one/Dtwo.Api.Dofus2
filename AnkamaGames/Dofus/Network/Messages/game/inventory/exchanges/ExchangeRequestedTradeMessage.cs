


















// Generated on 01/22/2023 17:42:57
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeRequestedTradeMessage : ExchangeRequestedMessage
{

public const uint Id = 5307;
public override uint MessageId
{
    get { return Id; }
}

public double source;
        public double target;
        

public ExchangeRequestedTradeMessage()
{
}

public ExchangeRequestedTradeMessage(sbyte exchangeType, double source, double target)
         : base(exchangeType)
        {
            this.source = source;
            this.target = target;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(source);
            writer.WriteVarLong(target);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            source = reader.ReadVarUhLong();
            target = reader.ReadVarUhLong();
            

}


}


}