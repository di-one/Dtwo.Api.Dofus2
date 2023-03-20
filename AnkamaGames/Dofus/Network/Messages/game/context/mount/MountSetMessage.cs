


















// Generated on 01/22/2023 17:42:44
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class MountSetMessage : Dofus2Message
{

public const uint Id = 4694;
public override uint MessageId
{
    get { return Id; }
}

public Types.MountClientData mountData;
        

public MountSetMessage()
{
}

public MountSetMessage(Types.MountClientData mountData)
        {
            this.mountData = mountData;
        }
        

public override void Serialize(IDataWriter writer)
{

mountData.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

mountData = new Types.MountClientData();
            mountData.Deserialize(reader);
            

}


}


}