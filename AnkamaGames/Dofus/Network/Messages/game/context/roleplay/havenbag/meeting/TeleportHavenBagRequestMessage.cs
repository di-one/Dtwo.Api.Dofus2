


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class TeleportHavenBagRequestMessage : Dofus2Message
{

public const uint Id = 3622;
public override uint MessageId
{
    get { return Id; }
}

public double guestId;
        

public TeleportHavenBagRequestMessage()
{
}

public TeleportHavenBagRequestMessage(double guestId)
        {
            this.guestId = guestId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(guestId);
            

}

public override void Deserialize(IDataReader reader)
{

guestId = reader.ReadVarUhLong();
            

}


}


}