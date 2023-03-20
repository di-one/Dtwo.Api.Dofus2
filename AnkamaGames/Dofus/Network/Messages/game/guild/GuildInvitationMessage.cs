


















// Generated on 01/22/2023 17:42:53
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildInvitationMessage : Dofus2Message
{

public const uint Id = 5372;
public override uint MessageId
{
    get { return Id; }
}

public double targetId;
        

public GuildInvitationMessage()
{
}

public GuildInvitationMessage(double targetId)
        {
            this.targetId = targetId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(targetId);
            

}

public override void Deserialize(IDataReader reader)
{

targetId = reader.ReadVarUhLong();
            

}


}


}