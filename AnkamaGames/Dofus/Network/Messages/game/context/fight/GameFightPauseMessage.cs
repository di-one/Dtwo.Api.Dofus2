


















// Generated on 01/22/2023 17:42:43
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameFightPauseMessage : Dofus2Message
{

public const uint Id = 4482;
public override uint MessageId
{
    get { return Id; }
}

public bool isPaused;
        

public GameFightPauseMessage()
{
}

public GameFightPauseMessage(bool isPaused)
        {
            this.isPaused = isPaused;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(isPaused);
            

}

public override void Deserialize(IDataReader reader)
{

isPaused = reader.ReadBoolean();
            

}


}


}