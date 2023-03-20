


















// Generated on 01/22/2023 17:42:43
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameMapMovementRequestMessage : Dofus2Message
{

public const uint Id = 337;
public override uint MessageId
{
    get { return Id; }
}

public short[] keyMovements;
        public double mapId;
        

public GameMapMovementRequestMessage()
{
}

public GameMapMovementRequestMessage(short[] keyMovements, double mapId)
        {
            this.keyMovements = keyMovements;
            this.mapId = mapId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)keyMovements.Length);
            foreach (var entry in keyMovements)
            {
                 writer.WriteShort(entry);
            }
            writer.WriteDouble(mapId);
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            keyMovements = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 keyMovements[i] = reader.ReadShort();
            }
            mapId = reader.ReadDouble();
            

}


}


}