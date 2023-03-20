


















// Generated on 01/22/2023 17:42:48
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PaddockPropertiesMessage : Dofus2Message
{

public const uint Id = 6829;
public override uint MessageId
{
    get { return Id; }
}

public Types.PaddockInstancesInformations properties;
        

public PaddockPropertiesMessage()
{
}

public PaddockPropertiesMessage(Types.PaddockInstancesInformations properties)
        {
            this.properties = properties;
        }
        

public override void Serialize(IDataWriter writer)
{

properties.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

properties = new Types.PaddockInstancesInformations();
            properties.Deserialize(reader);
            

}


}


}