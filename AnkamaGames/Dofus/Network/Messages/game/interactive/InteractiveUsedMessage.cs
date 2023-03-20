


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class InteractiveUsedMessage : Dofus2Message
{

public const uint Id = 4286;
public override uint MessageId
{
    get { return Id; }
}

public double entityId;
        public uint elemId;
        public uint skillId;
        public uint duration;
        public bool canMove;
        

public InteractiveUsedMessage()
{
}

public InteractiveUsedMessage(double entityId, uint elemId, uint skillId, uint duration, bool canMove)
        {
            this.entityId = entityId;
            this.elemId = elemId;
            this.skillId = skillId;
            this.duration = duration;
            this.canMove = canMove;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(entityId);
            writer.WriteVarInt((int)elemId);
            writer.WriteVarShort((int)skillId);
            writer.WriteVarShort((int)duration);
            writer.WriteBoolean(canMove);
            

}

public override void Deserialize(IDataReader reader)
{

entityId = reader.ReadVarUhLong();
            elemId = reader.ReadVarUhInt();
            skillId = reader.ReadVarUhShort();
            duration = reader.ReadVarUhShort();
            canMove = reader.ReadBoolean();
            

}


}


}