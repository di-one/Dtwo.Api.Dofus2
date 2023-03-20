


















// Generated on 01/22/2023 17:42:37
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AcquaintanceSearchMessage : Dofus2Message
{

public const uint Id = 1737;
public override uint MessageId
{
    get { return Id; }
}

public Types.AccountTagInformation tag;
        

public AcquaintanceSearchMessage()
{
}

public AcquaintanceSearchMessage(Types.AccountTagInformation tag)
        {
            this.tag = tag;
        }
        

public override void Serialize(IDataWriter writer)
{

tag.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

tag = new Types.AccountTagInformation();
            tag.Deserialize(reader);
            

}


}


}