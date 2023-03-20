


















// Generated on 01/22/2023 17:42:57
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeShopStockMovementRemovedMessage : Dofus2Message
{

public const uint Id = 882;
public override uint MessageId
{
    get { return Id; }
}

public uint objectId;
        

public ExchangeShopStockMovementRemovedMessage()
{
}

public ExchangeShopStockMovementRemovedMessage(uint objectId)
        {
            this.objectId = objectId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectId);
            

}

public override void Deserialize(IDataReader reader)
{

objectId = reader.ReadVarUhInt();
            

}


}


}