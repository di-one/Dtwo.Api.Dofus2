


















// Generated on 01/22/2023 17:42:49
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PartyInvitationRequestMessage : Dofus2Message
{

public const uint Id = 4199;
public override uint MessageId
{
    get { return Id; }
}

public Types.AbstractPlayerSearchInformation target;
        

public PartyInvitationRequestMessage()
{
}

public PartyInvitationRequestMessage(Types.AbstractPlayerSearchInformation target)
        {
            this.target = target;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(target.TypeId);
            target.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

target = ProtocolTypeManager.GetInstance<Types.AbstractPlayerSearchInformation>(reader.ReadUShort());
            target.Deserialize(reader);
            

}


}


}