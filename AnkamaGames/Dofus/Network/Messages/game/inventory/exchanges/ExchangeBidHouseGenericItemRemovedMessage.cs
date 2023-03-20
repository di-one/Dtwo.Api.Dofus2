


















// Generated on 01/22/2023 17:42:56
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeBidHouseGenericItemRemovedMessage : Dofus2Message
{

public const uint Id = 4227;
public override uint MessageId
{
    get { return Id; }
}

public uint objGenericId;
        

public ExchangeBidHouseGenericItemRemovedMessage()
{
}

public ExchangeBidHouseGenericItemRemovedMessage(uint objGenericId)
        {
            this.objGenericId = objGenericId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objGenericId);
            

}

public override void Deserialize(IDataReader reader)
{

objGenericId = reader.ReadVarUhInt();
            

}


}


}