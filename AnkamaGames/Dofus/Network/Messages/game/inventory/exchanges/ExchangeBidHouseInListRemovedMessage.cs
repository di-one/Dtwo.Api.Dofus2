


















// Generated on 01/22/2023 17:42:56
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeBidHouseInListRemovedMessage : Dofus2Message
{

public const uint Id = 531;
public override uint MessageId
{
    get { return Id; }
}

public int itemUID;
        public uint objectGID;
        public int objectType;
        

public ExchangeBidHouseInListRemovedMessage()
{
}

public ExchangeBidHouseInListRemovedMessage(int itemUID, uint objectGID, int objectType)
        {
            this.itemUID = itemUID;
            this.objectGID = objectGID;
            this.objectType = objectType;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(itemUID);
            writer.WriteVarInt((int)objectGID);
            writer.WriteInt(objectType);
            

}

public override void Deserialize(IDataReader reader)
{

itemUID = reader.ReadInt();
            objectGID = reader.ReadVarUhInt();
            objectType = reader.ReadInt();
            

}


}


}