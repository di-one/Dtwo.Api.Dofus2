


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildFightPlayersEnemiesListMessage : Dofus2Message
{

public const uint Id = 881;
public override uint MessageId
{
    get { return Id; }
}

public double fightId;
        public Types.CharacterMinimalPlusLookInformations[] playerInfo;
        

public GuildFightPlayersEnemiesListMessage()
{
}

public GuildFightPlayersEnemiesListMessage(double fightId, Types.CharacterMinimalPlusLookInformations[] playerInfo)
        {
            this.fightId = fightId;
            this.playerInfo = playerInfo;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(fightId);
            writer.WriteShort((short)playerInfo.Length);
            foreach (var entry in playerInfo)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

fightId = reader.ReadDouble();
            var limit = (ushort)reader.ReadUShort();
            playerInfo = new Types.CharacterMinimalPlusLookInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 playerInfo[i] = new Types.CharacterMinimalPlusLookInformations();
                 playerInfo[i].Deserialize(reader);
            }
            

}


}


}