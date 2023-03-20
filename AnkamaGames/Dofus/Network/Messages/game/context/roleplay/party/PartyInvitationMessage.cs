


















// Generated on 01/22/2023 17:42:49
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PartyInvitationMessage : AbstractPartyMessage
{

public const uint Id = 3195;
public override uint MessageId
{
    get { return Id; }
}

public sbyte partyType;
        public string partyName;
        public sbyte maxParticipants;
        public double fromId;
        public string fromName;
        public double toId;
        

public PartyInvitationMessage()
{
}

public PartyInvitationMessage(uint partyId, sbyte partyType, string partyName, sbyte maxParticipants, double fromId, string fromName, double toId)
         : base(partyId)
        {
            this.partyType = partyType;
            this.partyName = partyName;
            this.maxParticipants = maxParticipants;
            this.fromId = fromId;
            this.fromName = fromName;
            this.toId = toId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(partyType);
            writer.WriteUTF(partyName);
            writer.WriteSbyte(maxParticipants);
            writer.WriteVarLong(fromId);
            writer.WriteUTF(fromName);
            writer.WriteVarLong(toId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            partyType = reader.ReadSbyte();
            partyName = reader.ReadUTF();
            maxParticipants = reader.ReadSbyte();
            fromId = reader.ReadVarUhLong();
            fromName = reader.ReadUTF();
            toId = reader.ReadVarUhLong();
            

}


}


}