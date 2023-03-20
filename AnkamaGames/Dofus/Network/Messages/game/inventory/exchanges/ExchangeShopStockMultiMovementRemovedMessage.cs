


















// Generated on 01/22/2023 17:42:57
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeShopStockMultiMovementRemovedMessage : Dofus2Message
{

public const uint Id = 7522;
public override uint MessageId
{
    get { return Id; }
}

public uint[] objectIdList;
        

public ExchangeShopStockMultiMovementRemovedMessage()
{
}

public ExchangeShopStockMultiMovementRemovedMessage(uint[] objectIdList)
        {
            this.objectIdList = objectIdList;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)objectIdList.Length);
            foreach (var entry in objectIdList)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            objectIdList = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectIdList[i] = reader.ReadVarUhInt();
            }
            

}


}


}