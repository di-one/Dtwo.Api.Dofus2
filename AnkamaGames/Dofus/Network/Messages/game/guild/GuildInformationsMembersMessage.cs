


















// Generated on 01/22/2023 17:42:53
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildInformationsMembersMessage : Dofus2Message
{

public const uint Id = 1109;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildMember[] members;
        

public GuildInformationsMembersMessage()
{
}

public GuildInformationsMembersMessage(Types.GuildMember[] members)
        {
            this.members = members;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)members.Length);
            foreach (var entry in members)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            members = new Types.GuildMember[limit];
            for (int i = 0; i < limit; i++)
            {
                 members[i] = new Types.GuildMember();
                 members[i].Deserialize(reader);
            }
            

}


}


}