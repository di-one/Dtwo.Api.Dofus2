


















// Generated on 01/22/2023 17:42:49
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PartyInvitationDungeonDetailsMessage : PartyInvitationDetailsMessage
{

public const uint Id = 9547;
public override uint MessageId
{
    get { return Id; }
}

public uint dungeonId;
        public bool[] playersDungeonReady;
        

public PartyInvitationDungeonDetailsMessage()
{
}

public PartyInvitationDungeonDetailsMessage(uint partyId, sbyte partyType, string partyName, double fromId, string fromName, double leaderId, Types.PartyInvitationMemberInformations[] members, Types.PartyGuestInformations[] guests, uint dungeonId, bool[] playersDungeonReady)
         : base(partyId, partyType, partyName, fromId, fromName, leaderId, members, guests)
        {
            this.dungeonId = dungeonId;
            this.playersDungeonReady = playersDungeonReady;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)dungeonId);
            writer.WriteShort((short)playersDungeonReady.Length);
            foreach (var entry in playersDungeonReady)
            {
                 writer.WriteBoolean(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            dungeonId = reader.ReadVarUhShort();
            var limit = (ushort)reader.ReadUShort();
            playersDungeonReady = new bool[limit];
            for (int i = 0; i < limit; i++)
            {
                 playersDungeonReady[i] = reader.ReadBoolean();
            }
            

}


}


}