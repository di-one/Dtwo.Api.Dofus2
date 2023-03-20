


















// Generated on 01/22/2023 17:42:49
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PartyKickedByMessage : AbstractPartyMessage
{

public const uint Id = 3337;
public override uint MessageId
{
    get { return Id; }
}

public double kickerId;
        

public PartyKickedByMessage()
{
}

public PartyKickedByMessage(uint partyId, double kickerId)
         : base(partyId)
        {
            this.kickerId = kickerId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(kickerId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            kickerId = reader.ReadVarUhLong();
            

}


}


}