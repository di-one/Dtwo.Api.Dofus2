


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildApplicationListenMessage : Dofus2Message
{

public const uint Id = 6713;
public override uint MessageId
{
    get { return Id; }
}

public bool listen;
        

public GuildApplicationListenMessage()
{
}

public GuildApplicationListenMessage(bool listen)
        {
            this.listen = listen;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(listen);
            

}

public override void Deserialize(IDataReader reader)
{

listen = reader.ReadBoolean();
            

}


}


}