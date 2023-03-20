


















// Generated on 01/22/2023 17:42:49
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class DungeonPartyFinderRoomContentUpdateMessage : Dofus2Message
{

public const uint Id = 9135;
public override uint MessageId
{
    get { return Id; }
}

public uint dungeonId;
        public Types.DungeonPartyFinderPlayer[] addedPlayers;
        public double[] removedPlayersIds;
        

public DungeonPartyFinderRoomContentUpdateMessage()
{
}

public DungeonPartyFinderRoomContentUpdateMessage(uint dungeonId, Types.DungeonPartyFinderPlayer[] addedPlayers, double[] removedPlayersIds)
        {
            this.dungeonId = dungeonId;
            this.addedPlayers = addedPlayers;
            this.removedPlayersIds = removedPlayersIds;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)dungeonId);
            writer.WriteShort((short)addedPlayers.Length);
            foreach (var entry in addedPlayers)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)removedPlayersIds.Length);
            foreach (var entry in removedPlayersIds)
            {
                 writer.WriteVarLong(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

dungeonId = reader.ReadVarUhShort();
            var limit = (ushort)reader.ReadUShort();
            addedPlayers = new Types.DungeonPartyFinderPlayer[limit];
            for (int i = 0; i < limit; i++)
            {
                 addedPlayers[i] = new Types.DungeonPartyFinderPlayer();
                 addedPlayers[i].Deserialize(reader);
            }
            limit = (ushort)reader.ReadUShort();
            removedPlayersIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 removedPlayersIds[i] = reader.ReadVarUhLong();
            }
            

}


}


}