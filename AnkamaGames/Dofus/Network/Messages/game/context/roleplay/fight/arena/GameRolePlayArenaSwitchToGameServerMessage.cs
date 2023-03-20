


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameRolePlayArenaSwitchToGameServerMessage : Dofus2Message
{

public const uint Id = 7604;
public override uint MessageId
{
    get { return Id; }
}

public bool validToken;
        public string token;
        public short homeServerId;
        

public GameRolePlayArenaSwitchToGameServerMessage()
{
}

public GameRolePlayArenaSwitchToGameServerMessage(bool validToken, string token, short homeServerId)
        {
            this.validToken = validToken;
            this.token = token;
            this.homeServerId = homeServerId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(validToken);
            writer.WriteUTF(token);
            writer.WriteShort(homeServerId);
            

}

public override void Deserialize(IDataReader reader)
{

validToken = reader.ReadBoolean();
            token = reader.ReadUTF();
            homeServerId = reader.ReadShort();
            

}


}


}