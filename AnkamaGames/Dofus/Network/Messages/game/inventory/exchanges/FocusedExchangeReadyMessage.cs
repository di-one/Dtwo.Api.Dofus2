


















// Generated on 01/22/2023 17:42:58
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class FocusedExchangeReadyMessage : ExchangeReadyMessage
{

public const uint Id = 6757;
public override uint MessageId
{
    get { return Id; }
}

public uint focusActionId;
        

public FocusedExchangeReadyMessage()
{
}

public FocusedExchangeReadyMessage(bool ready, uint step, uint focusActionId)
         : base(ready, step)
        {
            this.focusActionId = focusActionId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)focusActionId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            focusActionId = reader.ReadVarUhInt();
            

}


}


}