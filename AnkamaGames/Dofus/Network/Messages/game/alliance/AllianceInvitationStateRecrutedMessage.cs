


















// Generated on 01/22/2023 17:42:39
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AllianceInvitationStateRecrutedMessage : Dofus2Message
{

public const uint Id = 1023;
public override uint MessageId
{
    get { return Id; }
}

public sbyte invitationState;
        

public AllianceInvitationStateRecrutedMessage()
{
}

public AllianceInvitationStateRecrutedMessage(sbyte invitationState)
        {
            this.invitationState = invitationState;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(invitationState);
            

}

public override void Deserialize(IDataReader reader)
{

invitationState = reader.ReadSbyte();
            

}


}


}