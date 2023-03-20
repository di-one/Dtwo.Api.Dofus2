


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameRolePlaySpellAnimMessage : Dofus2Message
{

public const uint Id = 5588;
public override uint MessageId
{
    get { return Id; }
}

public double casterId;
        public uint targetCellId;
        public uint spellId;
        public short spellLevel;
        public short direction;
        

public GameRolePlaySpellAnimMessage()
{
}

public GameRolePlaySpellAnimMessage(double casterId, uint targetCellId, uint spellId, short spellLevel, short direction)
        {
            this.casterId = casterId;
            this.targetCellId = targetCellId;
            this.spellId = spellId;
            this.spellLevel = spellLevel;
            this.direction = direction;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(casterId);
            writer.WriteVarShort((int)targetCellId);
            writer.WriteVarShort((int)spellId);
            writer.WriteShort(spellLevel);
            writer.WriteShort(direction);
            

}

public override void Deserialize(IDataReader reader)
{

casterId = reader.ReadVarUhLong();
            targetCellId = reader.ReadVarUhShort();
            spellId = reader.ReadVarUhShort();
            spellLevel = reader.ReadShort();
            direction = reader.ReadShort();
            

}


}


}