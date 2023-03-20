


















// Generated on 01/22/2023 17:42:59
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ObjectUseOnCellMessage : ObjectUseMessage
{

public const uint Id = 8862;
public override uint MessageId
{
    get { return Id; }
}

public uint cells;
        

public ObjectUseOnCellMessage()
{
}

public ObjectUseOnCellMessage(uint cells)
        {
            this.cells = cells;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)cells);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            cells = reader.ReadVarUhShort();
            

}


}


}