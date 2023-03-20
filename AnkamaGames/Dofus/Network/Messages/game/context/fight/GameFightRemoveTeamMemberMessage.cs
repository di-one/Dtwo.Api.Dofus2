


















// Generated on 01/22/2023 17:42:43
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameFightRemoveTeamMemberMessage : Dofus2Message
{

public const uint Id = 5999;
public override uint MessageId
{
    get { return Id; }
}

public uint fightId;
        public sbyte teamId;
        public double charId;
        

public GameFightRemoveTeamMemberMessage()
{
}

public GameFightRemoveTeamMemberMessage(uint fightId, sbyte teamId, double charId)
        {
            this.fightId = fightId;
            this.teamId = teamId;
            this.charId = charId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)fightId);
            writer.WriteSbyte(teamId);
            writer.WriteDouble(charId);
            

}

public override void Deserialize(IDataReader reader)
{

fightId = reader.ReadVarUhShort();
            teamId = reader.ReadSbyte();
            charId = reader.ReadDouble();
            

}


}


}