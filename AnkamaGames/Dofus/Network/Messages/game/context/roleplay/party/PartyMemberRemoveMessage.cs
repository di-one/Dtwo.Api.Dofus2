


















// Generated on 01/22/2023 17:42:50
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PartyMemberRemoveMessage : AbstractPartyEventMessage
{

public const uint Id = 1525;
public override uint MessageId
{
    get { return Id; }
}

public double leavingPlayerId;
        

public PartyMemberRemoveMessage()
{
}

public PartyMemberRemoveMessage(uint partyId, double leavingPlayerId)
         : base(partyId)
        {
            this.leavingPlayerId = leavingPlayerId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(leavingPlayerId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            leavingPlayerId = reader.ReadVarUhLong();
            

}


}


}