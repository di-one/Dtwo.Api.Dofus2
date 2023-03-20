


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ZaapDestinationsMessage : TeleportDestinationsMessage
{

public const uint Id = 5649;
public override uint MessageId
{
    get { return Id; }
}

public double spawnMapId;
        

public ZaapDestinationsMessage()
{
}

public ZaapDestinationsMessage(sbyte type, Types.TeleportDestination[] destinations, double spawnMapId)
         : base(type, destinations)
        {
            this.spawnMapId = spawnMapId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(spawnMapId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            spawnMapId = reader.ReadDouble();
            

}


}


}