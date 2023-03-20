


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildApplicationReceivedMessage : Dofus2Message
{

public const uint Id = 3627;
public override uint MessageId
{
    get { return Id; }
}

public string playerName;
        public double playerId;
        

public GuildApplicationReceivedMessage()
{
}

public GuildApplicationReceivedMessage(string playerName, double playerId)
        {
            this.playerName = playerName;
            this.playerId = playerId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(playerName);
            writer.WriteVarLong(playerId);
            

}

public override void Deserialize(IDataReader reader)
{

playerName = reader.ReadUTF();
            playerId = reader.ReadVarUhLong();
            

}


}


}