


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GuildPlayerFlowActivity : GuildLogbookEntryBasicInformation
{

public const short Id = 3798;
public override short TypeId
{
    get { return Id; }
}

public double playerId;
        public string playerName;
        public sbyte playerFlowEventType;
        

public GuildPlayerFlowActivity()
{
}

public GuildPlayerFlowActivity(uint id, double date, double playerId, string playerName, sbyte playerFlowEventType)
         : base(id, date)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.playerFlowEventType = playerFlowEventType;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(playerId);
            writer.WriteUTF(playerName);
            writer.WriteSbyte(playerFlowEventType);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
            playerName = reader.ReadUTF();
            playerFlowEventType = reader.ReadSbyte();
            

}


}


}