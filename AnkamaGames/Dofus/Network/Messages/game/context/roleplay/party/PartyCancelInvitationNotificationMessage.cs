


















// Generated on 01/22/2023 17:42:49
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PartyCancelInvitationNotificationMessage : AbstractPartyEventMessage
{

public const uint Id = 2983;
public override uint MessageId
{
    get { return Id; }
}

public double cancelerId;
        public double guestId;
        

public PartyCancelInvitationNotificationMessage()
{
}

public PartyCancelInvitationNotificationMessage(uint partyId, double cancelerId, double guestId)
         : base(partyId)
        {
            this.cancelerId = cancelerId;
            this.guestId = guestId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(cancelerId);
            writer.WriteVarLong(guestId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            cancelerId = reader.ReadVarUhLong();
            guestId = reader.ReadVarUhLong();
            

}


}


}