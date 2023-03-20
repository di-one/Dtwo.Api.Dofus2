


















// Generated on 01/22/2023 17:42:43
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameMapNoMovementMessage : Dofus2Message
{

public const uint Id = 979;
public override uint MessageId
{
    get { return Id; }
}

public short cellX;
        public short cellY;
        

public GameMapNoMovementMessage()
{
}

public GameMapNoMovementMessage(short cellX, short cellY)
        {
            this.cellX = cellX;
            this.cellY = cellY;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(cellX);
            writer.WriteShort(cellY);
            

}

public override void Deserialize(IDataReader reader)
{

cellX = reader.ReadShort();
            cellY = reader.ReadShort();
            

}


}


}