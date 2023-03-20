


















// Generated on 01/22/2023 17:42:50
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PartyMemberInBreachFightMessage : AbstractPartyMemberInFightMessage
{

public const uint Id = 4813;
public override uint MessageId
{
    get { return Id; }
}

public uint floor;
        public sbyte room;
        

public PartyMemberInBreachFightMessage()
{
}

public PartyMemberInBreachFightMessage(uint partyId, sbyte reason, double memberId, int memberAccountId, string memberName, uint fightId, int timeBeforeFightStart, uint floor, sbyte room)
         : base(partyId, reason, memberId, memberAccountId, memberName, fightId, timeBeforeFightStart)
        {
            this.floor = floor;
            this.room = room;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)floor);
            writer.WriteSbyte(room);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            floor = reader.ReadVarUhInt();
            room = reader.ReadSbyte();
            

}


}


}