


















// Generated on 01/22/2023 17:42:59
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AccessoryPreviewMessage : Dofus2Message
{

public const uint Id = 5940;
public override uint MessageId
{
    get { return Id; }
}

public Types.EntityLook look;
        

public AccessoryPreviewMessage()
{
}

public AccessoryPreviewMessage(Types.EntityLook look)
        {
            this.look = look;
        }
        

public override void Serialize(IDataWriter writer)
{

look.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

look = new Types.EntityLook();
            look.Deserialize(reader);
            

}


}


}