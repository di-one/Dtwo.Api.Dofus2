


















// Generated on 01/22/2023 17:42:37
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameActionFightCastRequestMessage : Dofus2Message
{

public const uint Id = 3791;
public override uint MessageId
{
    get { return Id; }
}

public uint spellId;
        public short cellId;
        

public GameActionFightCastRequestMessage()
{
}

public GameActionFightCastRequestMessage(uint spellId, short cellId)
        {
            this.spellId = spellId;
            this.cellId = cellId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)spellId);
            writer.WriteShort(cellId);
            

}

public override void Deserialize(IDataReader reader)
{

spellId = reader.ReadVarUhShort();
            cellId = reader.ReadShort();
            

}


}


}