


















// Generated on 01/22/2023 17:43:05
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GuildInformations : BasicGuildInformations
{

public const short Id = 5879;
public override short TypeId
{
    get { return Id; }
}

public Types.GuildEmblem guildEmblem;
        

public GuildInformations()
{
}

public GuildInformations(uint guildId, string guildName, byte guildLevel, Types.GuildEmblem guildEmblem)
         : base(guildId, guildName, guildLevel)
        {
            this.guildEmblem = guildEmblem;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            guildEmblem.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            guildEmblem = new Types.GuildEmblem();
            guildEmblem.Deserialize(reader);
            

}


}


}