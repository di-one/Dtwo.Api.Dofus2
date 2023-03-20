


















// Generated on 01/22/2023 17:42:53
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildListMessage : Dofus2Message
{

public const uint Id = 4090;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildInformations[] guilds;
        

public GuildListMessage()
{
}

public GuildListMessage(Types.GuildInformations[] guilds)
        {
            this.guilds = guilds;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)guilds.Length);
            foreach (var entry in guilds)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            guilds = new Types.GuildInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 guilds[i] = new Types.GuildInformations();
                 guilds[i].Deserialize(reader);
            }
            

}


}


}