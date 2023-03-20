


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameRolePlayPlayerFightFriendlyRequestedMessage : Dofus2Message
{

public const uint Id = 7175;
public override uint MessageId
{
    get { return Id; }
}

public uint fightId;
        public double sourceId;
        public double targetId;
        

public GameRolePlayPlayerFightFriendlyRequestedMessage()
{
}

public GameRolePlayPlayerFightFriendlyRequestedMessage(uint fightId, double sourceId, double targetId)
        {
            this.fightId = fightId;
            this.sourceId = sourceId;
            this.targetId = targetId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)fightId);
            writer.WriteVarLong(sourceId);
            writer.WriteVarLong(targetId);
            

}

public override void Deserialize(IDataReader reader)
{

fightId = reader.ReadVarUhShort();
            sourceId = reader.ReadVarUhLong();
            targetId = reader.ReadVarUhLong();
            

}


}


}