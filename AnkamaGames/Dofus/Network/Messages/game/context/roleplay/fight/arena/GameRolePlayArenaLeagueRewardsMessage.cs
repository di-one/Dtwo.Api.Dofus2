


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameRolePlayArenaLeagueRewardsMessage : Dofus2Message
{

public const uint Id = 1870;
public override uint MessageId
{
    get { return Id; }
}

public uint seasonId;
        public uint leagueId;
        public int ladderPosition;
        public bool endSeasonReward;
        

public GameRolePlayArenaLeagueRewardsMessage()
{
}

public GameRolePlayArenaLeagueRewardsMessage(uint seasonId, uint leagueId, int ladderPosition, bool endSeasonReward)
        {
            this.seasonId = seasonId;
            this.leagueId = leagueId;
            this.ladderPosition = ladderPosition;
            this.endSeasonReward = endSeasonReward;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)seasonId);
            writer.WriteVarShort((int)leagueId);
            writer.WriteInt(ladderPosition);
            writer.WriteBoolean(endSeasonReward);
            

}

public override void Deserialize(IDataReader reader)
{

seasonId = reader.ReadVarUhShort();
            leagueId = reader.ReadVarUhShort();
            ladderPosition = reader.ReadInt();
            endSeasonReward = reader.ReadBoolean();
            

}


}


}