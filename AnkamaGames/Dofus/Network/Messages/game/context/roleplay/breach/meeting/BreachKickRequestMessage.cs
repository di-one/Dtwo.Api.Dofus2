


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BreachKickRequestMessage : Dofus2Message
{

public const uint Id = 1343;
public override uint MessageId
{
    get { return Id; }
}

public double target;
        

public BreachKickRequestMessage()
{
}

public BreachKickRequestMessage(double target)
        {
            this.target = target;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(target);
            

}

public override void Deserialize(IDataReader reader)
{

target = reader.ReadVarUhLong();
            

}


}


}