


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HavenBagDailyLoteryMessage : Dofus2Message
{

public const uint Id = 3458;
public override uint MessageId
{
    get { return Id; }
}

public string gameActionId;
        

public HavenBagDailyLoteryMessage()
{
}

public HavenBagDailyLoteryMessage(string gameActionId)
        {
            this.gameActionId = gameActionId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(gameActionId);
            

}

public override void Deserialize(IDataReader reader)
{

gameActionId = reader.ReadUTF();
            

}


}


}