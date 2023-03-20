


















// Generated on 01/22/2023 17:42:36
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ServersListMessage : Dofus2Message
{

public const uint Id = 1619;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameServerInformations[] servers;
        public bool canCreateNewCharacter;
        

public ServersListMessage()
{
}

public ServersListMessage(Types.GameServerInformations[] servers, bool canCreateNewCharacter)
        {
            this.servers = servers;
            this.canCreateNewCharacter = canCreateNewCharacter;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)servers.Length);
            foreach (var entry in servers)
            {
                 entry.Serialize(writer);
            }
            writer.WriteBoolean(canCreateNewCharacter);
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            servers = new Types.GameServerInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 servers[i] = new Types.GameServerInformations();
                 servers[i].Deserialize(reader);
            }
            canCreateNewCharacter = reader.ReadBoolean();
            

}


}


}