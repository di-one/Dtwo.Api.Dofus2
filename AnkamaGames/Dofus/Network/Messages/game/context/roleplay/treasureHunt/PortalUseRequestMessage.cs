


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PortalUseRequestMessage : Dofus2Message
{

public const uint Id = 4099;
public override uint MessageId
{
    get { return Id; }
}

public uint portalId;
        

public PortalUseRequestMessage()
{
}

public PortalUseRequestMessage(uint portalId)
        {
            this.portalId = portalId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)portalId);
            

}

public override void Deserialize(IDataReader reader)
{

portalId = reader.ReadVarUhInt();
            

}


}


}