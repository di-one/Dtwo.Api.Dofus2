


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildPlayerApplicationInformationMessage : GuildPlayerApplicationAbstractMessage
{

public const uint Id = 7125;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildInformations guildInformation;
        public Types.GuildApplicationInformation apply;
        

public GuildPlayerApplicationInformationMessage()
{
}

public GuildPlayerApplicationInformationMessage(Types.GuildInformations guildInformation, Types.GuildApplicationInformation apply)
        {
            this.guildInformation = guildInformation;
            this.apply = apply;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            guildInformation.Serialize(writer);
            apply.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            guildInformation = new Types.GuildInformations();
            guildInformation.Deserialize(reader);
            apply = new Types.GuildApplicationInformation();
            apply.Deserialize(reader);
            

}


}


}