


















// Generated on 01/22/2023 17:42:58
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeStartOkHumanVendorMessage : Dofus2Message
{

public const uint Id = 8980;
public override uint MessageId
{
    get { return Id; }
}

public double sellerId;
        public Types.ObjectItemToSellInHumanVendorShop[] objectsInfos;
        

public ExchangeStartOkHumanVendorMessage()
{
}

public ExchangeStartOkHumanVendorMessage(double sellerId, Types.ObjectItemToSellInHumanVendorShop[] objectsInfos)
        {
            this.sellerId = sellerId;
            this.objectsInfos = objectsInfos;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(sellerId);
            writer.WriteShort((short)objectsInfos.Length);
            foreach (var entry in objectsInfos)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

sellerId = reader.ReadDouble();
            var limit = (ushort)reader.ReadUShort();
            objectsInfos = new Types.ObjectItemToSellInHumanVendorShop[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectsInfos[i] = new Types.ObjectItemToSellInHumanVendorShop();
                 objectsInfos[i].Deserialize(reader);
            }
            

}


}


}