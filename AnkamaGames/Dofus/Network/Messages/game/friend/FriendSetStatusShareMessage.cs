


















// Generated on 01/22/2023 17:42:52
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class FriendSetStatusShareMessage : Dofus2Message
{

public const uint Id = 4480;
public override uint MessageId
{
    get { return Id; }
}

public bool share;
        

public FriendSetStatusShareMessage()
{
}

public FriendSetStatusShareMessage(bool share)
        {
            this.share = share;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(share);
            

}

public override void Deserialize(IDataReader reader)
{

share = reader.ReadBoolean();
            

}


}


}