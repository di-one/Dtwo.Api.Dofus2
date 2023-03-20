


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class CurrentMapInstanceMessage : CurrentMapMessage
{

public const uint Id = 4457;
public override uint MessageId
{
    get { return Id; }
}

public double instantiatedMapId;
        

public CurrentMapInstanceMessage()
{
}

public CurrentMapInstanceMessage(double mapId, double instantiatedMapId)
         : base(mapId)
        {
            this.instantiatedMapId = instantiatedMapId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(instantiatedMapId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            instantiatedMapId = reader.ReadDouble();
            

}


}


}