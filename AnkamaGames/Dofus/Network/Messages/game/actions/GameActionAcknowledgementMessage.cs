


















// Generated on 01/22/2023 17:42:37
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameActionAcknowledgementMessage : Dofus2Message
{

public const uint Id = 4836;
public override uint MessageId
{
    get { return Id; }
}

public bool valid;
        public sbyte actionId;
        

public GameActionAcknowledgementMessage()
{
}

public GameActionAcknowledgementMessage(bool valid, sbyte actionId)
        {
            this.valid = valid;
            this.actionId = actionId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(valid);
            writer.WriteSbyte(actionId);
            

}

public override void Deserialize(IDataReader reader)
{

valid = reader.ReadBoolean();
            actionId = reader.ReadSbyte();
            

}


}


}