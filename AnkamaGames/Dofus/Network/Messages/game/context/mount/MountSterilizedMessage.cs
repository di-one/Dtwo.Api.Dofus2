


















// Generated on 01/22/2023 17:42:44
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class MountSterilizedMessage : Dofus2Message
{

public const uint Id = 5301;
public override uint MessageId
{
    get { return Id; }
}

public int mountId;
        

public MountSterilizedMessage()
{
}

public MountSterilizedMessage(int mountId)
        {
            this.mountId = mountId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)mountId);
            

}

public override void Deserialize(IDataReader reader)
{

mountId = reader.ReadVarInt();
            

}


}


}