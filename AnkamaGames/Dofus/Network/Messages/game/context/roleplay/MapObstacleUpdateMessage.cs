


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class MapObstacleUpdateMessage : Dofus2Message
{

public const uint Id = 3382;
public override uint MessageId
{
    get { return Id; }
}

public Types.MapObstacle[] obstacles;
        

public MapObstacleUpdateMessage()
{
}

public MapObstacleUpdateMessage(Types.MapObstacle[] obstacles)
        {
            this.obstacles = obstacles;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)obstacles.Length);
            foreach (var entry in obstacles)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            obstacles = new Types.MapObstacle[limit];
            for (int i = 0; i < limit; i++)
            {
                 obstacles[i] = new Types.MapObstacle();
                 obstacles[i].Deserialize(reader);
            }
            

}


}


}