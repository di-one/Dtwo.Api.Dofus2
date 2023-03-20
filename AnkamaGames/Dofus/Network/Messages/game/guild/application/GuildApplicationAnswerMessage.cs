


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildApplicationAnswerMessage : Dofus2Message
{

public const uint Id = 8254;
public override uint MessageId
{
    get { return Id; }
}

public bool accepted;
        public double playerId;
        

public GuildApplicationAnswerMessage()
{
}

public GuildApplicationAnswerMessage(bool accepted, double playerId)
        {
            this.accepted = accepted;
            this.playerId = playerId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(accepted);
            writer.WriteVarLong(playerId);
            

}

public override void Deserialize(IDataReader reader)
{

accepted = reader.ReadBoolean();
            playerId = reader.ReadVarUhLong();
            

}


}


}