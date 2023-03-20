


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BreachEnterMessage : Dofus2Message
{

public const uint Id = 6288;
public override uint MessageId
{
    get { return Id; }
}

public double owner;
        

public BreachEnterMessage()
{
}

public BreachEnterMessage(double owner)
        {
            this.owner = owner;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(owner);
            

}

public override void Deserialize(IDataReader reader)
{

owner = reader.ReadVarUhLong();
            

}


}


}