


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class EnterHavenBagRequestMessage : Dofus2Message
{

public const uint Id = 6131;
public override uint MessageId
{
    get { return Id; }
}

public double havenBagOwner;
        

public EnterHavenBagRequestMessage()
{
}

public EnterHavenBagRequestMessage(double havenBagOwner)
        {
            this.havenBagOwner = havenBagOwner;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(havenBagOwner);
            

}

public override void Deserialize(IDataReader reader)
{

havenBagOwner = reader.ReadVarUhLong();
            

}


}


}