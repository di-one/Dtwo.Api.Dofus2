


















// Generated on 01/22/2023 17:42:49
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PartyCannotJoinErrorMessage : AbstractPartyMessage
{

public const uint Id = 8151;
public override uint MessageId
{
    get { return Id; }
}

public sbyte reason;
        

public PartyCannotJoinErrorMessage()
{
}

public PartyCannotJoinErrorMessage(uint partyId, sbyte reason)
         : base(partyId)
        {
            this.reason = reason;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(reason);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            reason = reader.ReadSbyte();
            

}


}


}