


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BreachInvitationResponseMessage : Dofus2Message
{

public const uint Id = 8900;
public override uint MessageId
{
    get { return Id; }
}

public Types.CharacterMinimalInformations guest;
        public bool accept;
        

public BreachInvitationResponseMessage()
{
}

public BreachInvitationResponseMessage(Types.CharacterMinimalInformations guest, bool accept)
        {
            this.guest = guest;
            this.accept = accept;
        }
        

public override void Serialize(IDataWriter writer)
{

guest.Serialize(writer);
            writer.WriteBoolean(accept);
            

}

public override void Deserialize(IDataReader reader)
{

guest = new Types.CharacterMinimalInformations();
            guest.Deserialize(reader);
            accept = reader.ReadBoolean();
            

}


}


}