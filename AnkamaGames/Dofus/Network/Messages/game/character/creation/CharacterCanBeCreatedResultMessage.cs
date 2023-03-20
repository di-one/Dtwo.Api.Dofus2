


















// Generated on 01/22/2023 17:42:41
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class CharacterCanBeCreatedResultMessage : Dofus2Message
{

public const uint Id = 7681;
public override uint MessageId
{
    get { return Id; }
}

public bool yesYouCan;
        

public CharacterCanBeCreatedResultMessage()
{
}

public CharacterCanBeCreatedResultMessage(bool yesYouCan)
        {
            this.yesYouCan = yesYouCan;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(yesYouCan);
            

}

public override void Deserialize(IDataReader reader)
{

yesYouCan = reader.ReadBoolean();
            

}


}


}