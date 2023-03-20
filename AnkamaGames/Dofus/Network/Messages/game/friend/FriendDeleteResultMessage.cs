


















// Generated on 01/22/2023 17:42:52
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class FriendDeleteResultMessage : Dofus2Message
{

public const uint Id = 4536;
public override uint MessageId
{
    get { return Id; }
}

public bool success;
        public Types.AccountTagInformation tag;
        

public FriendDeleteResultMessage()
{
}

public FriendDeleteResultMessage(bool success, Types.AccountTagInformation tag)
        {
            this.success = success;
            this.tag = tag;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(success);
            tag.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

success = reader.ReadBoolean();
            tag = new Types.AccountTagInformation();
            tag.Deserialize(reader);
            

}


}


}