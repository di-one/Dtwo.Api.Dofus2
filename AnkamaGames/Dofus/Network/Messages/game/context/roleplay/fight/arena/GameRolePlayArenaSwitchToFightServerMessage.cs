


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameRolePlayArenaSwitchToFightServerMessage : Dofus2Message
{

public const uint Id = 6455;
public override uint MessageId
{
    get { return Id; }
}

public string address;
        public uint[] ports;
        public string token;
        

public GameRolePlayArenaSwitchToFightServerMessage()
{
}

public GameRolePlayArenaSwitchToFightServerMessage(string address, uint[] ports, string token)
        {
            this.address = address;
            this.ports = ports;
            this.token = token;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(address);
            writer.WriteShort((short)ports.Length);
            foreach (var entry in ports)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteUTF(token);
            

}

public override void Deserialize(IDataReader reader)
{

address = reader.ReadUTF();
            var limit = (ushort)reader.ReadUShort();
            ports = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 ports[i] = reader.ReadVarUhShort();
            }
            token = reader.ReadUTF();
            

}


}


}