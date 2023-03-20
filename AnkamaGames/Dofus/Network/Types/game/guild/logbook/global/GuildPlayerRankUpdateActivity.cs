


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GuildPlayerRankUpdateActivity : GuildLogbookEntryBasicInformation
{

public const short Id = 9810;
public override short TypeId
{
    get { return Id; }
}

public Types.GuildRankMinimalInformation guildRankMinimalInfos;
        public double sourcePlayerId;
        public double targetPlayerId;
        public string sourcePlayerName;
        public string targetPlayerName;
        

public GuildPlayerRankUpdateActivity()
{
}

public GuildPlayerRankUpdateActivity(uint id, double date, Types.GuildRankMinimalInformation guildRankMinimalInfos, double sourcePlayerId, double targetPlayerId, string sourcePlayerName, string targetPlayerName)
         : base(id, date)
        {
            this.guildRankMinimalInfos = guildRankMinimalInfos;
            this.sourcePlayerId = sourcePlayerId;
            this.targetPlayerId = targetPlayerId;
            this.sourcePlayerName = sourcePlayerName;
            this.targetPlayerName = targetPlayerName;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            guildRankMinimalInfos.Serialize(writer);
            writer.WriteVarLong(sourcePlayerId);
            writer.WriteVarLong(targetPlayerId);
            writer.WriteUTF(sourcePlayerName);
            writer.WriteUTF(targetPlayerName);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            guildRankMinimalInfos = new Types.GuildRankMinimalInformation();
            guildRankMinimalInfos.Deserialize(reader);
            sourcePlayerId = reader.ReadVarUhLong();
            targetPlayerId = reader.ReadVarUhLong();
            sourcePlayerName = reader.ReadUTF();
            targetPlayerName = reader.ReadUTF();
            

}


}


}