


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HavenBagPermissionsUpdateRequestMessage : Dofus2Message
{

public const uint Id = 3448;
public override uint MessageId
{
    get { return Id; }
}

public int permissions;
        

public HavenBagPermissionsUpdateRequestMessage()
{
}

public HavenBagPermissionsUpdateRequestMessage(int permissions)
        {
            this.permissions = permissions;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(permissions);
            

}

public override void Deserialize(IDataReader reader)
{

permissions = reader.ReadInt();
            

}


}


}