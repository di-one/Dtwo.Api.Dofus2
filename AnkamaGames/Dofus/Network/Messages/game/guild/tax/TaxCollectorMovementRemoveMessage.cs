


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class TaxCollectorMovementRemoveMessage : Dofus2Message
{

public const uint Id = 4860;
public override uint MessageId
{
    get { return Id; }
}

public double collectorId;
        

public TaxCollectorMovementRemoveMessage()
{
}

public TaxCollectorMovementRemoveMessage(double collectorId)
        {
            this.collectorId = collectorId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(collectorId);
            

}

public override void Deserialize(IDataReader reader)
{

collectorId = reader.ReadDouble();
            

}


}


}