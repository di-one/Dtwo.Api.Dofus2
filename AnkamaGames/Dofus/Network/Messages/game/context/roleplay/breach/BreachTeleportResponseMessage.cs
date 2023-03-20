


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BreachTeleportResponseMessage : Dofus2Message
{

public const uint Id = 8020;
public override uint MessageId
{
    get { return Id; }
}

public bool teleported;
        

public BreachTeleportResponseMessage()
{
}

public BreachTeleportResponseMessage(bool teleported)
        {
            this.teleported = teleported;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(teleported);
            

}

public override void Deserialize(IDataReader reader)
{

teleported = reader.ReadBoolean();
            

}


}


}