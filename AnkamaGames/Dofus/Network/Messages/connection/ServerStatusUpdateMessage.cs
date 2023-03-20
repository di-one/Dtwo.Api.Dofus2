


















// Generated on 01/22/2023 17:42:36
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ServerStatusUpdateMessage : Dofus2Message
{

public const uint Id = 3;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameServerInformations server;
        

public ServerStatusUpdateMessage()
{
}

public ServerStatusUpdateMessage(Types.GameServerInformations server)
        {
            this.server = server;
        }
        

public override void Serialize(IDataWriter writer)
{

server.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

server = new Types.GameServerInformations();
            server.Deserialize(reader);
            

}


}


}