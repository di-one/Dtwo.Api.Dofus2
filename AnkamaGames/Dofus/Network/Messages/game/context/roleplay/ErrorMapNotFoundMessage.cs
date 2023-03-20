


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ErrorMapNotFoundMessage : Dofus2Message
{

public const uint Id = 6990;
public override uint MessageId
{
    get { return Id; }
}

public double mapId;
        

public ErrorMapNotFoundMessage()
{
}

public ErrorMapNotFoundMessage(double mapId)
        {
            this.mapId = mapId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(mapId);
            

}

public override void Deserialize(IDataReader reader)
{

mapId = reader.ReadDouble();
            

}


}


}