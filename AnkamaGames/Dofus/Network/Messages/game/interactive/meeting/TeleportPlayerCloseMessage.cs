


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class TeleportPlayerCloseMessage : Dofus2Message
{

public const uint Id = 3576;
public override uint MessageId
{
    get { return Id; }
}

public double mapId;
        public double requesterId;
        

public TeleportPlayerCloseMessage()
{
}

public TeleportPlayerCloseMessage(double mapId, double requesterId)
        {
            this.mapId = mapId;
            this.requesterId = requesterId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(mapId);
            writer.WriteVarLong(requesterId);
            

}

public override void Deserialize(IDataReader reader)
{

mapId = reader.ReadDouble();
            requesterId = reader.ReadVarUhLong();
            

}


}


}