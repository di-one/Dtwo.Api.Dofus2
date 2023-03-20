


















// Generated on 01/22/2023 17:42:43
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class DungeonKeyRingMessage : Dofus2Message
{

public const uint Id = 2456;
public override uint MessageId
{
    get { return Id; }
}

public uint[] availables;
        public uint[] unavailables;
        

public DungeonKeyRingMessage()
{
}

public DungeonKeyRingMessage(uint[] availables, uint[] unavailables)
        {
            this.availables = availables;
            this.unavailables = unavailables;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)availables.Length);
            foreach (var entry in availables)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)unavailables.Length);
            foreach (var entry in unavailables)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            availables = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 availables[i] = reader.ReadVarUhShort();
            }
            limit = (ushort)reader.ReadUShort();
            unavailables = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 unavailables[i] = reader.ReadVarUhShort();
            }
            

}


}


}