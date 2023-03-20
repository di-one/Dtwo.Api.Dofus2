


















// Generated on 01/22/2023 17:42:44
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameFightUpdateTeamMessage : Dofus2Message
{

public const uint Id = 6345;
public override uint MessageId
{
    get { return Id; }
}

public uint fightId;
        public Types.FightTeamInformations team;
        

public GameFightUpdateTeamMessage()
{
}

public GameFightUpdateTeamMessage(uint fightId, Types.FightTeamInformations team)
        {
            this.fightId = fightId;
            this.team = team;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)fightId);
            team.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

fightId = reader.ReadVarUhShort();
            team = new Types.FightTeamInformations();
            team.Deserialize(reader);
            

}


}


}