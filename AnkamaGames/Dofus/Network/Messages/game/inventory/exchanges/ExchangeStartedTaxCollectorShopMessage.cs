


















// Generated on 01/22/2023 17:42:57
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeStartedTaxCollectorShopMessage : Dofus2Message
{

public const uint Id = 8837;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem[] objects;
        public double kamas;
        

public ExchangeStartedTaxCollectorShopMessage()
{
}

public ExchangeStartedTaxCollectorShopMessage(Types.ObjectItem[] objects, double kamas)
        {
            this.objects = objects;
            this.kamas = kamas;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)objects.Length);
            foreach (var entry in objects)
            {
                 entry.Serialize(writer);
            }
            writer.WriteVarLong(kamas);
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            objects = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 objects[i] = new Types.ObjectItem();
                 objects[i].Deserialize(reader);
            }
            kamas = reader.ReadVarUhLong();
            

}


}


}