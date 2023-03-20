


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ChangeMapMessage : Dofus2Message
{

public const uint Id = 7988;
public override uint MessageId
{
    get { return Id; }
}

public double mapId;
        public bool autopilot;
        

public ChangeMapMessage()
{
}

public ChangeMapMessage(double mapId, bool autopilot)
        {
            this.mapId = mapId;
            this.autopilot = autopilot;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(mapId);
            writer.WriteBoolean(autopilot);
            

}

public override void Deserialize(IDataReader reader)
{

mapId = reader.ReadDouble();
            autopilot = reader.ReadBoolean();
            

}


}


}