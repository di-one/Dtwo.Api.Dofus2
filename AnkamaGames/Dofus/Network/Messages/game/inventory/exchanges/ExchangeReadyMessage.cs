


















// Generated on 01/22/2023 17:42:57
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeReadyMessage : Dofus2Message
{

public const uint Id = 8296;
public override uint MessageId
{
    get { return Id; }
}

public bool ready;
        public uint step;
        

public ExchangeReadyMessage()
{
}

public ExchangeReadyMessage(bool ready, uint step)
        {
            this.ready = ready;
            this.step = step;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(ready);
            writer.WriteVarShort((int)step);
            

}

public override void Deserialize(IDataReader reader)
{

ready = reader.ReadBoolean();
            step = reader.ReadVarUhShort();
            

}


}


}