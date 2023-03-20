


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BreachInvitationCloseMessage : Dofus2Message
{

public const uint Id = 3545;
public override uint MessageId
{
    get { return Id; }
}

public Types.CharacterMinimalInformations host;
        

public BreachInvitationCloseMessage()
{
}

public BreachInvitationCloseMessage(Types.CharacterMinimalInformations host)
        {
            this.host = host;
        }
        

public override void Serialize(IDataWriter writer)
{

host.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

host = new Types.CharacterMinimalInformations();
            host.Deserialize(reader);
            

}


}


}