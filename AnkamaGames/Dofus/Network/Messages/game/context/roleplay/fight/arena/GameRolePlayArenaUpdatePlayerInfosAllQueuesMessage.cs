


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameRolePlayArenaUpdatePlayerInfosAllQueuesMessage : GameRolePlayArenaUpdatePlayerInfosMessage
{

public const uint Id = 6951;
public override uint MessageId
{
    get { return Id; }
}

public Types.ArenaRankInfos team;
        public Types.ArenaRankInfos duel;
        

public GameRolePlayArenaUpdatePlayerInfosAllQueuesMessage()
{
}

public GameRolePlayArenaUpdatePlayerInfosAllQueuesMessage(Types.ArenaRankInfos solo, Types.ArenaRankInfos team, Types.ArenaRankInfos duel)
         : base(solo)
        {
            this.team = team;
            this.duel = duel;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            team.Serialize(writer);
            duel.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            team = new Types.ArenaRankInfos();
            team.Deserialize(reader);
            duel = new Types.ArenaRankInfos();
            duel.Deserialize(reader);
            

}


}


}