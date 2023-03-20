


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameRolePlayArenaFighterStatusMessage : Dofus2Message
{

public const uint Id = 2258;
public override uint MessageId
{
    get { return Id; }
}

public uint fightId;
        public double playerId;
        public bool accepted;
        

public GameRolePlayArenaFighterStatusMessage()
{
}

public GameRolePlayArenaFighterStatusMessage(uint fightId, double playerId, bool accepted)
        {
            this.fightId = fightId;
            this.playerId = playerId;
            this.accepted = accepted;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)fightId);
            writer.WriteVarLong(playerId);
            writer.WriteBoolean(accepted);
            

}

public override void Deserialize(IDataReader reader)
{

fightId = reader.ReadVarUhShort();
            playerId = reader.ReadVarUhLong();
            accepted = reader.ReadBoolean();
            

}


}


}