


















// Generated on 01/22/2023 17:42:56
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeBidHouseUnsoldItemsMessage : Dofus2Message
{

public const uint Id = 4267;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItemGenericQuantity[] items;
        

public ExchangeBidHouseUnsoldItemsMessage()
{
}

public ExchangeBidHouseUnsoldItemsMessage(Types.ObjectItemGenericQuantity[] items)
        {
            this.items = items;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)items.Length);
            foreach (var entry in items)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            items = new Types.ObjectItemGenericQuantity[limit];
            for (int i = 0; i < limit; i++)
            {
                 items[i] = new Types.ObjectItemGenericQuantity();
                 items[i].Deserialize(reader);
            }
            

}


}


}