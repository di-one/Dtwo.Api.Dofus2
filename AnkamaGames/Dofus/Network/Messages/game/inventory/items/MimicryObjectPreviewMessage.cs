


















// Generated on 01/22/2023 17:42:59
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class MimicryObjectPreviewMessage : Dofus2Message
{

public const uint Id = 816;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem result;
        

public MimicryObjectPreviewMessage()
{
}

public MimicryObjectPreviewMessage(Types.ObjectItem result)
        {
            this.result = result;
        }
        

public override void Serialize(IDataWriter writer)
{

result.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

result = new Types.ObjectItem();
            result.Deserialize(reader);
            

}


}


}