


















// Generated on 01/22/2023 17:42:36
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class SelectedServerDataMessage : Dofus2Message
{

public const uint Id = 8715;
public override uint MessageId
{
    get { return Id; }
}

public uint serverId;
        public string address;
        public uint[] ports;
        public bool canCreateNewCharacter;
        public sbyte[] ticket;
        

public SelectedServerDataMessage()
{
}

public SelectedServerDataMessage(uint serverId, string address, uint[] ports, bool canCreateNewCharacter, sbyte[] ticket)
        {
            this.serverId = serverId;
            this.address = address;
            this.ports = ports;
            this.canCreateNewCharacter = canCreateNewCharacter;
            this.ticket = ticket;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)serverId);
            writer.WriteUTF(address);
            writer.WriteShort((short)ports.Length);
            foreach (var entry in ports)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteBoolean(canCreateNewCharacter);
            writer.WriteVarInt((int)(ushort)ticket.Length);
            foreach (var entry in ticket)
            {
                 writer.WriteSbyte(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

serverId = reader.ReadVarUhShort();
            address = reader.ReadUTF();
            var limit = (ushort)reader.ReadUShort();
            ports = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 ports[i] = reader.ReadVarUhShort();
            }
            canCreateNewCharacter = reader.ReadBoolean();
            limit = (ushort)reader.ReadVarInt();
            ticket = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 ticket[i] = reader.ReadSbyte();
            }
            

}


}


}