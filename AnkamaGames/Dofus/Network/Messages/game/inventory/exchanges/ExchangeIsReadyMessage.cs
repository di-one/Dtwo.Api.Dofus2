


















// Generated on 01/22/2023 17:42:56
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeIsReadyMessage : Dofus2Message
{

public const uint Id = 8027;
public override uint MessageId
{
    get { return Id; }
}

public double id;
        public bool ready;
        

public ExchangeIsReadyMessage()
{
}

public ExchangeIsReadyMessage(double id, bool ready)
        {
            this.id = id;
            this.ready = ready;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(id);
            writer.WriteBoolean(ready);
            

}

public override void Deserialize(IDataReader reader)
{

id = reader.ReadDouble();
            ready = reader.ReadBoolean();
            

}


}


}