


















// Generated on 01/22/2023 17:42:57
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeOfflineSoldItemsMessage : Dofus2Message
{

public const uint Id = 4323;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItemQuantityPriceDateEffects[] bidHouseItems;
        public Types.ObjectItemQuantityPriceDateEffects[] merchantItems;
        

public ExchangeOfflineSoldItemsMessage()
{
}

public ExchangeOfflineSoldItemsMessage(Types.ObjectItemQuantityPriceDateEffects[] bidHouseItems, Types.ObjectItemQuantityPriceDateEffects[] merchantItems)
        {
            this.bidHouseItems = bidHouseItems;
            this.merchantItems = merchantItems;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)bidHouseItems.Length);
            foreach (var entry in bidHouseItems)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)merchantItems.Length);
            foreach (var entry in merchantItems)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            bidHouseItems = new Types.ObjectItemQuantityPriceDateEffects[limit];
            for (int i = 0; i < limit; i++)
            {
                 bidHouseItems[i] = new Types.ObjectItemQuantityPriceDateEffects();
                 bidHouseItems[i].Deserialize(reader);
            }
            limit = (ushort)reader.ReadUShort();
            merchantItems = new Types.ObjectItemQuantityPriceDateEffects[limit];
            for (int i = 0; i < limit; i++)
            {
                 merchantItems[i] = new Types.ObjectItemQuantityPriceDateEffects();
                 merchantItems[i].Deserialize(reader);
            }
            

}


}


}