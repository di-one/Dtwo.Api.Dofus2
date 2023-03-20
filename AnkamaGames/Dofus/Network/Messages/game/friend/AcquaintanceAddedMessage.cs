


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AcquaintanceAddedMessage : Dofus2Message
{

public const uint Id = 8361;
public override uint MessageId
{
    get { return Id; }
}

public Types.AcquaintanceInformation acquaintanceAdded;
        

public AcquaintanceAddedMessage()
{
}

public AcquaintanceAddedMessage(Types.AcquaintanceInformation acquaintanceAdded)
        {
            this.acquaintanceAdded = acquaintanceAdded;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(acquaintanceAdded.TypeId);
            acquaintanceAdded.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

acquaintanceAdded = ProtocolTypeManager.GetInstance<Types.AcquaintanceInformation>(reader.ReadUShort());
            acquaintanceAdded.Deserialize(reader);
            

}


}


}