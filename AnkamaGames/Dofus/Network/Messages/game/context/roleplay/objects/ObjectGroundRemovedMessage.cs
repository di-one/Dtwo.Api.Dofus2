


















// Generated on 01/22/2023 17:42:48
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ObjectGroundRemovedMessage : Dofus2Message
{

public const uint Id = 416;
public override uint MessageId
{
    get { return Id; }
}

public uint cell;
        

public ObjectGroundRemovedMessage()
{
}

public ObjectGroundRemovedMessage(uint cell)
        {
            this.cell = cell;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)cell);
            

}

public override void Deserialize(IDataReader reader)
{

cell = reader.ReadVarUhShort();
            

}


}


}