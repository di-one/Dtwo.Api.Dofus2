


















// Generated on 01/22/2023 17:42:57
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeSellMessage : Dofus2Message
{

public const uint Id = 2826;
public override uint MessageId
{
    get { return Id; }
}

public uint objectToSellId;
        public uint quantity;
        

public ExchangeSellMessage()
{
}

public ExchangeSellMessage(uint objectToSellId, uint quantity)
        {
            this.objectToSellId = objectToSellId;
            this.quantity = quantity;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectToSellId);
            writer.WriteVarInt((int)quantity);
            

}

public override void Deserialize(IDataReader reader)
{

objectToSellId = reader.ReadVarUhInt();
            quantity = reader.ReadVarUhInt();
            

}


}


}