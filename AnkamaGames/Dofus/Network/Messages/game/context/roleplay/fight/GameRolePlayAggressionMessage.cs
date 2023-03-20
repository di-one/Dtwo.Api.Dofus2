


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameRolePlayAggressionMessage : Dofus2Message
{

public const uint Id = 3544;
public override uint MessageId
{
    get { return Id; }
}

public double attackerId;
        public double defenderId;
        

public GameRolePlayAggressionMessage()
{
}

public GameRolePlayAggressionMessage(double attackerId, double defenderId)
        {
            this.attackerId = attackerId;
            this.defenderId = defenderId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(attackerId);
            writer.WriteVarLong(defenderId);
            

}

public override void Deserialize(IDataReader reader)
{

attackerId = reader.ReadVarUhLong();
            defenderId = reader.ReadVarUhLong();
            

}


}


}