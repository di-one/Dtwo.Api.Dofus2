


















// Generated on 01/22/2023 17:42:44
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameFightTurnFinishMessage : Dofus2Message
{

public const uint Id = 703;
public override uint MessageId
{
    get { return Id; }
}

public bool isAfk;
        

public GameFightTurnFinishMessage()
{
}

public GameFightTurnFinishMessage(bool isAfk)
        {
            this.isAfk = isAfk;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(isAfk);
            

}

public override void Deserialize(IDataReader reader)
{

isAfk = reader.ReadBoolean();
            

}


}


}