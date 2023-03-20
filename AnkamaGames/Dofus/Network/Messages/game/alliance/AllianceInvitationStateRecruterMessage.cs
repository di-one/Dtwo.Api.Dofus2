


















// Generated on 01/22/2023 17:42:39
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AllianceInvitationStateRecruterMessage : Dofus2Message
{

public const uint Id = 1453;
public override uint MessageId
{
    get { return Id; }
}

public string recrutedName;
        public sbyte invitationState;
        

public AllianceInvitationStateRecruterMessage()
{
}

public AllianceInvitationStateRecruterMessage(string recrutedName, sbyte invitationState)
        {
            this.recrutedName = recrutedName;
            this.invitationState = invitationState;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(recrutedName);
            writer.WriteSbyte(invitationState);
            

}

public override void Deserialize(IDataReader reader)
{

recrutedName = reader.ReadUTF();
            invitationState = reader.ReadSbyte();
            

}


}


}