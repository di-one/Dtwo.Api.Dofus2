


















// Generated on 01/22/2023 17:42:56
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeBuyMessage : Dofus2Message
{

public const uint Id = 3840;
public override uint MessageId
{
    get { return Id; }
}

public uint objectToBuyId;
        public uint quantity;
        

public ExchangeBuyMessage()
{
}

public ExchangeBuyMessage(uint objectToBuyId, uint quantity)
        {
            this.objectToBuyId = objectToBuyId;
            this.quantity = quantity;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectToBuyId);
            writer.WriteVarInt((int)quantity);
            

}

public override void Deserialize(IDataReader reader)
{

objectToBuyId = reader.ReadVarUhInt();
            quantity = reader.ReadVarUhInt();
            

}


}


}