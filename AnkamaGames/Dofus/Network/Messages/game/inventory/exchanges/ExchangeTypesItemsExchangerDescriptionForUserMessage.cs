


















// Generated on 01/22/2023 17:42:58
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeTypesItemsExchangerDescriptionForUserMessage : Dofus2Message
{

public const uint Id = 6062;
public override uint MessageId
{
    get { return Id; }
}

public uint objectGID;
        public int objectType;
        public Types.BidExchangerObjectInfo[] itemTypeDescriptions;
        

public ExchangeTypesItemsExchangerDescriptionForUserMessage()
{
}

public ExchangeTypesItemsExchangerDescriptionForUserMessage(uint objectGID, int objectType, Types.BidExchangerObjectInfo[] itemTypeDescriptions)
        {
            this.objectGID = objectGID;
            this.objectType = objectType;
            this.itemTypeDescriptions = itemTypeDescriptions;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectGID);
            writer.WriteInt(objectType);
            writer.WriteShort((short)itemTypeDescriptions.Length);
            foreach (var entry in itemTypeDescriptions)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

objectGID = reader.ReadVarUhInt();
            objectType = reader.ReadInt();
            var limit = (ushort)reader.ReadUShort();
            itemTypeDescriptions = new Types.BidExchangerObjectInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 itemTypeDescriptions[i] = new Types.BidExchangerObjectInfo();
                 itemTypeDescriptions[i].Deserialize(reader);
            }
            

}


}


}