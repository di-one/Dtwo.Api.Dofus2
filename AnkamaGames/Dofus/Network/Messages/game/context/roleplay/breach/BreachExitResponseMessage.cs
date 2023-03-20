


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BreachExitResponseMessage : Dofus2Message
{

public const uint Id = 4165;
public override uint MessageId
{
    get { return Id; }
}

public bool exited;
        

public BreachExitResponseMessage()
{
}

public BreachExitResponseMessage(bool exited)
        {
            this.exited = exited;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(exited);
            

}

public override void Deserialize(IDataReader reader)
{

exited = reader.ReadBoolean();
            

}


}


}