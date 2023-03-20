


















// Generated on 01/22/2023 17:42:52
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuestModeMessage : Dofus2Message
{

public const uint Id = 3302;
public override uint MessageId
{
    get { return Id; }
}

public bool active;
        

public GuestModeMessage()
{
}

public GuestModeMessage(bool active)
        {
            this.active = active;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(active);
            

}

public override void Deserialize(IDataReader reader)
{

active = reader.ReadBoolean();
            

}


}


}