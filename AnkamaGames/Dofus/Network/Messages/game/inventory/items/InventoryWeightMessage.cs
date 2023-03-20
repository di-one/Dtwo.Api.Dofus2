


















// Generated on 01/22/2023 17:42:58
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class InventoryWeightMessage : Dofus2Message
{

public const uint Id = 5080;
public override uint MessageId
{
    get { return Id; }
}

public uint inventoryWeight;
        public uint shopWeight;
        public uint weightMax;
        

public InventoryWeightMessage()
{
}

public InventoryWeightMessage(uint inventoryWeight, uint shopWeight, uint weightMax)
        {
            this.inventoryWeight = inventoryWeight;
            this.shopWeight = shopWeight;
            this.weightMax = weightMax;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)inventoryWeight);
            writer.WriteVarInt((int)shopWeight);
            writer.WriteVarInt((int)weightMax);
            

}

public override void Deserialize(IDataReader reader)
{

inventoryWeight = reader.ReadVarUhInt();
            shopWeight = reader.ReadVarUhInt();
            weightMax = reader.ReadVarUhInt();
            

}


}


}