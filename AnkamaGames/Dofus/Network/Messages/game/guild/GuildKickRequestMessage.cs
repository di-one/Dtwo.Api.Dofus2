


















// Generated on 01/22/2023 17:42:53
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildKickRequestMessage : Dofus2Message
{

public const uint Id = 7155;
public override uint MessageId
{
    get { return Id; }
}

public double kickedId;
        

public GuildKickRequestMessage()
{
}

public GuildKickRequestMessage(double kickedId)
        {
            this.kickedId = kickedId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(kickedId);
            

}

public override void Deserialize(IDataReader reader)
{

kickedId = reader.ReadVarUhLong();
            

}


}


}