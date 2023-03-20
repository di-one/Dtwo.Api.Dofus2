


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildApplicationDeletedMessage : Dofus2Message
{

public const uint Id = 2223;
public override uint MessageId
{
    get { return Id; }
}

public bool deleted;
        

public GuildApplicationDeletedMessage()
{
}

public GuildApplicationDeletedMessage(bool deleted)
        {
            this.deleted = deleted;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(deleted);
            

}

public override void Deserialize(IDataReader reader)
{

deleted = reader.ReadBoolean();
            

}


}


}