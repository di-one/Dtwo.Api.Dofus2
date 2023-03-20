


















// Generated on 01/22/2023 17:42:44
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PaddockMoveItemRequestMessage : Dofus2Message
{

public const uint Id = 2379;
public override uint MessageId
{
    get { return Id; }
}

public uint oldCellId;
        public uint newCellId;
        

public PaddockMoveItemRequestMessage()
{
}

public PaddockMoveItemRequestMessage(uint oldCellId, uint newCellId)
        {
            this.oldCellId = oldCellId;
            this.newCellId = newCellId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)oldCellId);
            writer.WriteVarShort((int)newCellId);
            

}

public override void Deserialize(IDataReader reader)
{

oldCellId = reader.ReadVarUhShort();
            newCellId = reader.ReadVarUhShort();
            

}


}


}