


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class MapFightStartPositionsUpdateMessage : Dofus2Message
{

public const uint Id = 8655;
public override uint MessageId
{
    get { return Id; }
}

public double mapId;
        public Types.FightStartingPositions fightStartPositions;
        

public MapFightStartPositionsUpdateMessage()
{
}

public MapFightStartPositionsUpdateMessage(double mapId, Types.FightStartingPositions fightStartPositions)
        {
            this.mapId = mapId;
            this.fightStartPositions = fightStartPositions;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(mapId);
            fightStartPositions.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

mapId = reader.ReadDouble();
            fightStartPositions = new Types.FightStartingPositions();
            fightStartPositions.Deserialize(reader);
            

}


}


}