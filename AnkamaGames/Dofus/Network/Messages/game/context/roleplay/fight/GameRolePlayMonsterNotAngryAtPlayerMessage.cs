


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameRolePlayMonsterNotAngryAtPlayerMessage : Dofus2Message
{

public const uint Id = 2005;
public override uint MessageId
{
    get { return Id; }
}

public double playerId;
        public double monsterGroupId;
        

public GameRolePlayMonsterNotAngryAtPlayerMessage()
{
}

public GameRolePlayMonsterNotAngryAtPlayerMessage(double playerId, double monsterGroupId)
        {
            this.playerId = playerId;
            this.monsterGroupId = monsterGroupId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(playerId);
            writer.WriteDouble(monsterGroupId);
            

}

public override void Deserialize(IDataReader reader)
{

playerId = reader.ReadVarUhLong();
            monsterGroupId = reader.ReadDouble();
            

}


}


}