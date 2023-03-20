


















// Generated on 01/22/2023 17:42:37
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AcquaintanceServerListMessage : Dofus2Message
{

public const uint Id = 2240;
public override uint MessageId
{
    get { return Id; }
}

public uint[] servers;
        

public AcquaintanceServerListMessage()
{
}

public AcquaintanceServerListMessage(uint[] servers)
        {
            this.servers = servers;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)servers.Length);
            foreach (var entry in servers)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            servers = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 servers[i] = reader.ReadVarUhShort();
            }
            

}


}


}