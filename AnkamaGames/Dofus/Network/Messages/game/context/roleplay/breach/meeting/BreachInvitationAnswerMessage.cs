


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BreachInvitationAnswerMessage : Dofus2Message
{

public const uint Id = 6419;
public override uint MessageId
{
    get { return Id; }
}

public bool accept;
        

public BreachInvitationAnswerMessage()
{
}

public BreachInvitationAnswerMessage(bool accept)
        {
            this.accept = accept;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(accept);
            

}

public override void Deserialize(IDataReader reader)
{

accept = reader.ReadBoolean();
            

}


}


}