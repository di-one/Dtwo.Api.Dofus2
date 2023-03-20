


















// Generated on 01/22/2023 17:42:53
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildMemberLeavingMessage : Dofus2Message
{

public const uint Id = 5346;
public override uint MessageId
{
    get { return Id; }
}

public bool kicked;
        public double memberId;
        

public GuildMemberLeavingMessage()
{
}

public GuildMemberLeavingMessage(bool kicked, double memberId)
        {
            this.kicked = kicked;
            this.memberId = memberId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(kicked);
            writer.WriteVarLong(memberId);
            

}

public override void Deserialize(IDataReader reader)
{

kicked = reader.ReadBoolean();
            memberId = reader.ReadVarUhLong();
            

}


}


}