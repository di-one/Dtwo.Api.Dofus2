


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildFightPlayersHelpersLeaveMessage : Dofus2Message
{

public const uint Id = 5912;
public override uint MessageId
{
    get { return Id; }
}

public double fightId;
        public double playerId;
        

public GuildFightPlayersHelpersLeaveMessage()
{
}

public GuildFightPlayersHelpersLeaveMessage(double fightId, double playerId)
        {
            this.fightId = fightId;
            this.playerId = playerId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(fightId);
            writer.WriteVarLong(playerId);
            

}

public override void Deserialize(IDataReader reader)
{

fightId = reader.ReadDouble();
            playerId = reader.ReadVarUhLong();
            

}


}


}