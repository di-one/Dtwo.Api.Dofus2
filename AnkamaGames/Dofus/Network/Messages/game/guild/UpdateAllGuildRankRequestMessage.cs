


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class UpdateAllGuildRankRequestMessage : Dofus2Message
{

public const uint Id = 4628;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildRankInformation[] ranks;
        

public UpdateAllGuildRankRequestMessage()
{
}

public UpdateAllGuildRankRequestMessage(Types.GuildRankInformation[] ranks)
        {
            this.ranks = ranks;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)ranks.Length);
            foreach (var entry in ranks)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            ranks = new Types.GuildRankInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 ranks[i] = new Types.GuildRankInformation();
                 ranks[i].Deserialize(reader);
            }
            

}


}


}