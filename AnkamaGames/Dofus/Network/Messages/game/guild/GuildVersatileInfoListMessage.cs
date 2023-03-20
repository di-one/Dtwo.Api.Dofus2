


















// Generated on 01/22/2023 17:42:53
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildVersatileInfoListMessage : Dofus2Message
{

public const uint Id = 3841;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildVersatileInformations[] guilds;
        

public GuildVersatileInfoListMessage()
{
}

public GuildVersatileInfoListMessage(Types.GuildVersatileInformations[] guilds)
        {
            this.guilds = guilds;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)guilds.Length);
            foreach (var entry in guilds)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            guilds = new Types.GuildVersatileInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 guilds[i] = ProtocolTypeManager.GetInstance<Types.GuildVersatileInformations>(reader.ReadUShort());
                 guilds[i].Deserialize(reader);
            }
            

}


}


}