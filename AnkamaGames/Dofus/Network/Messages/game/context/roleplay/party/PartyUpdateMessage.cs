


















// Generated on 01/22/2023 17:42:50
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PartyUpdateMessage : AbstractPartyEventMessage
{

public const uint Id = 9563;
public override uint MessageId
{
    get { return Id; }
}

public Types.PartyMemberInformations memberInformations;
        

public PartyUpdateMessage()
{
}

public PartyUpdateMessage(uint partyId, Types.PartyMemberInformations memberInformations)
         : base(partyId)
        {
            this.memberInformations = memberInformations;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(memberInformations.TypeId);
            memberInformations.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            memberInformations = ProtocolTypeManager.GetInstance<Types.PartyMemberInformations>(reader.ReadUShort());
            memberInformations.Deserialize(reader);
            

}


}


}