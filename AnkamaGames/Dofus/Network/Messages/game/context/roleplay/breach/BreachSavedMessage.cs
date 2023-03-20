


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BreachSavedMessage : Dofus2Message
{

public const uint Id = 6598;
public override uint MessageId
{
    get { return Id; }
}

public bool saved;
        

public BreachSavedMessage()
{
}

public BreachSavedMessage(bool saved)
        {
            this.saved = saved;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(saved);
            

}

public override void Deserialize(IDataReader reader)
{

saved = reader.ReadBoolean();
            

}


}


}