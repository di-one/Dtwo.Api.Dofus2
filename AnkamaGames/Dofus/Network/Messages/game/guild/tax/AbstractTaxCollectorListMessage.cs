


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AbstractTaxCollectorListMessage : Dofus2Message
{

public const uint Id = 5610;
public override uint MessageId
{
    get { return Id; }
}

public Types.TaxCollectorInformations[] informations;
        

public AbstractTaxCollectorListMessage()
{
}

public AbstractTaxCollectorListMessage(Types.TaxCollectorInformations[] informations)
        {
            this.informations = informations;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)informations.Length);
            foreach (var entry in informations)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            informations = new Types.TaxCollectorInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 informations[i] = ProtocolTypeManager.GetInstance<Types.TaxCollectorInformations>(reader.ReadUShort());
                 informations[i].Deserialize(reader);
            }
            

}


}


}