


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildFightPlayersHelpersJoinMessage : Dofus2Message
{

public const uint Id = 5728;
public override uint MessageId
{
    get { return Id; }
}

public double fightId;
        public Types.CharacterMinimalPlusLookInformations playerInfo;
        

public GuildFightPlayersHelpersJoinMessage()
{
}

public GuildFightPlayersHelpersJoinMessage(double fightId, Types.CharacterMinimalPlusLookInformations playerInfo)
        {
            this.fightId = fightId;
            this.playerInfo = playerInfo;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(fightId);
            playerInfo.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

fightId = reader.ReadDouble();
            playerInfo = new Types.CharacterMinimalPlusLookInformations();
            playerInfo.Deserialize(reader);
            

}


}


}