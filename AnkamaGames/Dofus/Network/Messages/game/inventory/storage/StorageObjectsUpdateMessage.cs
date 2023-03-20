


















// Generated on 01/22/2023 17:42:59
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class StorageObjectsUpdateMessage : Dofus2Message
{

public const uint Id = 8558;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem[] objectList;
        

public StorageObjectsUpdateMessage()
{
}

public StorageObjectsUpdateMessage(Types.ObjectItem[] objectList)
        {
            this.objectList = objectList;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)objectList.Length);
            foreach (var entry in objectList)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            objectList = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectList[i] = new Types.ObjectItem();
                 objectList[i].Deserialize(reader);
            }
            

}


}


}