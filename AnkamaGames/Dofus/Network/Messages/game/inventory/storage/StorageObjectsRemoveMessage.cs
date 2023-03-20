


















// Generated on 01/22/2023 17:42:59
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class StorageObjectsRemoveMessage : Dofus2Message
{

public const uint Id = 7738;
public override uint MessageId
{
    get { return Id; }
}

public uint[] objectUIDList;
        

public StorageObjectsRemoveMessage()
{
}

public StorageObjectsRemoveMessage(uint[] objectUIDList)
        {
            this.objectUIDList = objectUIDList;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)objectUIDList.Length);
            foreach (var entry in objectUIDList)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            objectUIDList = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectUIDList[i] = reader.ReadVarUhInt();
            }
            

}


}


}