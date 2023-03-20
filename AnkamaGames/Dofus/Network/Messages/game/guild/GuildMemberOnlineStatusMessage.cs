


















// Generated on 01/22/2023 17:42:53
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildMemberOnlineStatusMessage : Dofus2Message
{

public const uint Id = 3512;
public override uint MessageId
{
    get { return Id; }
}

public double memberId;
        public bool online;
        

public GuildMemberOnlineStatusMessage()
{
}

public GuildMemberOnlineStatusMessage(double memberId, bool online)
        {
            this.memberId = memberId;
            this.online = online;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(memberId);
            writer.WriteBoolean(online);
            

}

public override void Deserialize(IDataReader reader)
{

memberId = reader.ReadVarUhLong();
            online = reader.ReadBoolean();
            

}


}


}