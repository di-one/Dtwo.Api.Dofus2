


















// Generated on 01/22/2023 17:42:58
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeWeightMessage : Dofus2Message
{

public const uint Id = 825;
public override uint MessageId
{
    get { return Id; }
}

public uint currentWeight;
        public uint maxWeight;
        

public ExchangeWeightMessage()
{
}

public ExchangeWeightMessage(uint currentWeight, uint maxWeight)
        {
            this.currentWeight = currentWeight;
            this.maxWeight = maxWeight;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)currentWeight);
            writer.WriteVarInt((int)maxWeight);
            

}

public override void Deserialize(IDataReader reader)
{

currentWeight = reader.ReadVarUhInt();
            maxWeight = reader.ReadVarUhInt();
            

}


}


}