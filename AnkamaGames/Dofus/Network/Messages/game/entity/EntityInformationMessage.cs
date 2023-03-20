


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class EntityInformationMessage : Dofus2Message
{

public const uint Id = 9199;
public override uint MessageId
{
    get { return Id; }
}

public Types.EntityInformation entity;
        

public EntityInformationMessage()
{
}

public EntityInformationMessage(Types.EntityInformation entity)
        {
            this.entity = entity;
        }
        

public override void Serialize(IDataWriter writer)
{

entity.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

entity = new Types.EntityInformation();
            entity.Deserialize(reader);
            

}


}


}