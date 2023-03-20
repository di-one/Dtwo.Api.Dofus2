


















// Generated on 01/22/2023 17:42:37
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameActionSpamMessage : Dofus2Message
{

public const uint Id = 835;
public override uint MessageId
{
    get { return Id; }
}

public short[] cells;
        

public GameActionSpamMessage()
{
}

public GameActionSpamMessage(short[] cells)
        {
            this.cells = cells;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)cells.Length);
            foreach (var entry in cells)
            {
                 writer.WriteShort(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            cells = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 cells[i] = reader.ReadShort();
            }
            

}


}


}