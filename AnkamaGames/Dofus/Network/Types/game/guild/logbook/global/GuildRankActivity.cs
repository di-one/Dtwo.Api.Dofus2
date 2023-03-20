


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GuildRankActivity : GuildLogbookEntryBasicInformation
{

public const short Id = 3613;
public override short TypeId
{
    get { return Id; }
}

public sbyte rankActivityType;
        public Types.GuildRankMinimalInformation guildRankMinimalInfos;
        

public GuildRankActivity()
{
}

public GuildRankActivity(uint id, double date, sbyte rankActivityType, Types.GuildRankMinimalInformation guildRankMinimalInfos)
         : base(id, date)
        {
            this.rankActivityType = rankActivityType;
            this.guildRankMinimalInfos = guildRankMinimalInfos;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(rankActivityType);
            guildRankMinimalInfos.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            rankActivityType = reader.ReadSbyte();
            guildRankMinimalInfos = new Types.GuildRankMinimalInformation();
            guildRankMinimalInfos.Deserialize(reader);
            

}


}


}