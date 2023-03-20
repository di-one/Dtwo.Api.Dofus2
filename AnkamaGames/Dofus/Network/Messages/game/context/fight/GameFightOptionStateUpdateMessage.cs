


















// Generated on 01/22/2023 17:42:43
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameFightOptionStateUpdateMessage : Dofus2Message
{

public const uint Id = 9503;
public override uint MessageId
{
    get { return Id; }
}

public uint fightId;
        public sbyte teamId;
        public sbyte option;
        public bool state;
        

public GameFightOptionStateUpdateMessage()
{
}

public GameFightOptionStateUpdateMessage(uint fightId, sbyte teamId, sbyte option, bool state)
        {
            this.fightId = fightId;
            this.teamId = teamId;
            this.option = option;
            this.state = state;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)fightId);
            writer.WriteSbyte(teamId);
            writer.WriteSbyte(option);
            writer.WriteBoolean(state);
            

}

public override void Deserialize(IDataReader reader)
{

fightId = reader.ReadVarUhShort();
            teamId = reader.ReadSbyte();
            option = reader.ReadSbyte();
            state = reader.ReadBoolean();
            

}


}


}