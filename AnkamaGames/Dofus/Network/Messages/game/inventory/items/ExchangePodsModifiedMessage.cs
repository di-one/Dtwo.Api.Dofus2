


















// Generated on 01/22/2023 17:42:58
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangePodsModifiedMessage : ExchangeObjectMessage
{

public const uint Id = 3685;
public override uint MessageId
{
    get { return Id; }
}

public uint currentWeight;
        public uint maxWeight;
        

public ExchangePodsModifiedMessage()
{
}

public ExchangePodsModifiedMessage(bool remote, uint currentWeight, uint maxWeight)
         : base(remote)
        {
            this.currentWeight = currentWeight;
            this.maxWeight = maxWeight;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)currentWeight);
            writer.WriteVarInt((int)maxWeight);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            currentWeight = reader.ReadVarUhInt();
            maxWeight = reader.ReadVarUhInt();
            

}


}


}