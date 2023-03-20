


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameRolePlayMonsterAngryAtPlayerMessage : Dofus2Message
{

public const uint Id = 6312;
public override uint MessageId
{
    get { return Id; }
}

public double playerId;
        public double monsterGroupId;
        public double angryStartTime;
        public double attackTime;
        

public GameRolePlayMonsterAngryAtPlayerMessage()
{
}

public GameRolePlayMonsterAngryAtPlayerMessage(double playerId, double monsterGroupId, double angryStartTime, double attackTime)
        {
            this.playerId = playerId;
            this.monsterGroupId = monsterGroupId;
            this.angryStartTime = angryStartTime;
            this.attackTime = attackTime;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(playerId);
            writer.WriteDouble(monsterGroupId);
            writer.WriteDouble(angryStartTime);
            writer.WriteDouble(attackTime);
            

}

public override void Deserialize(IDataReader reader)
{

playerId = reader.ReadVarUhLong();
            monsterGroupId = reader.ReadDouble();
            angryStartTime = reader.ReadDouble();
            attackTime = reader.ReadDouble();
            

}


}


}