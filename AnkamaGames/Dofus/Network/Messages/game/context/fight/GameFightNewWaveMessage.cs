


















// Generated on 01/22/2023 17:42:43
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameFightNewWaveMessage : Dofus2Message
{

public const uint Id = 1173;
public override uint MessageId
{
    get { return Id; }
}

public sbyte id;
        public sbyte teamId;
        public short nbTurnBeforeNextWave;
        

public GameFightNewWaveMessage()
{
}

public GameFightNewWaveMessage(sbyte id, sbyte teamId, short nbTurnBeforeNextWave)
        {
            this.id = id;
            this.teamId = teamId;
            this.nbTurnBeforeNextWave = nbTurnBeforeNextWave;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(id);
            writer.WriteSbyte(teamId);
            writer.WriteShort(nbTurnBeforeNextWave);
            

}

public override void Deserialize(IDataReader reader)
{

id = reader.ReadSbyte();
            teamId = reader.ReadSbyte();
            nbTurnBeforeNextWave = reader.ReadShort();
            

}


}


}