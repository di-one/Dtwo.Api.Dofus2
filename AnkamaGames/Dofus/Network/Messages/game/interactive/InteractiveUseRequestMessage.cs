


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class InteractiveUseRequestMessage : Dofus2Message
{

public const uint Id = 1411;
public override uint MessageId
{
    get { return Id; }
}

public uint elemId;
        public uint skillInstanceUid;
        

public InteractiveUseRequestMessage()
{
}

public InteractiveUseRequestMessage(uint elemId, uint skillInstanceUid)
        {
            this.elemId = elemId;
            this.skillInstanceUid = skillInstanceUid;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)elemId);
            writer.WriteVarInt((int)skillInstanceUid);
            

}

public override void Deserialize(IDataReader reader)
{

elemId = reader.ReadVarUhInt();
            skillInstanceUid = reader.ReadVarUhInt();
            

}


}


}