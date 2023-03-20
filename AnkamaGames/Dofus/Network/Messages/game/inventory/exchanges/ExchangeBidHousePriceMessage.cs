


















// Generated on 01/22/2023 17:42:56
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeBidHousePriceMessage : Dofus2Message
{

public const uint Id = 347;
public override uint MessageId
{
    get { return Id; }
}

public uint objectGID;
        

public ExchangeBidHousePriceMessage()
{
}

public ExchangeBidHousePriceMessage(uint objectGID)
        {
            this.objectGID = objectGID;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectGID);
            

}

public override void Deserialize(IDataReader reader)
{

objectGID = reader.ReadVarUhInt();
            

}


}


}