


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class InteractiveUseEndedMessage : Dofus2Message
{

public const uint Id = 5477;
public override uint MessageId
{
    get { return Id; }
}

public uint elemId;
        public uint skillId;
        

public InteractiveUseEndedMessage()
{
}

public InteractiveUseEndedMessage(uint elemId, uint skillId)
        {
            this.elemId = elemId;
            this.skillId = skillId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)elemId);
            writer.WriteVarShort((int)skillId);
            

}

public override void Deserialize(IDataReader reader)
{

elemId = reader.ReadVarUhInt();
            skillId = reader.ReadVarUhShort();
            

}


}


}