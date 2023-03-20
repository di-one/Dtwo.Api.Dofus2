


















// Generated on 01/22/2023 17:42:53
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildModificationNameValidMessage : Dofus2Message
{

public const uint Id = 3560;
public override uint MessageId
{
    get { return Id; }
}

public string guildName;
        

public GuildModificationNameValidMessage()
{
}

public GuildModificationNameValidMessage(string guildName)
        {
            this.guildName = guildName;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(guildName);
            

}

public override void Deserialize(IDataReader reader)
{

guildName = reader.ReadUTF();
            

}


}


}