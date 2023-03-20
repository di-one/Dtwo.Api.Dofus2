


















// Generated on 01/22/2023 17:43:01
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class StartupActionAddMessage : Dofus2Message
{

public const uint Id = 4490;
public override uint MessageId
{
    get { return Id; }
}

public Types.StartupActionAddObject newAction;
        

public StartupActionAddMessage()
{
}

public StartupActionAddMessage(Types.StartupActionAddObject newAction)
        {
            this.newAction = newAction;
        }
        

public override void Serialize(IDataWriter writer)
{

newAction.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

newAction = new Types.StartupActionAddObject();
            newAction.Deserialize(reader);
            

}


}


}