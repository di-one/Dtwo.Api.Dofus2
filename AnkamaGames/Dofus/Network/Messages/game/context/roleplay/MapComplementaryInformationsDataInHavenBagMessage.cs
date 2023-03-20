


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class MapComplementaryInformationsDataInHavenBagMessage : MapComplementaryInformationsDataMessage
{

public const uint Id = 5052;
public override uint MessageId
{
    get { return Id; }
}

public Types.CharacterMinimalInformations ownerInformations;
        public sbyte theme;
        public sbyte roomId;
        public sbyte maxRoomId;
        

public MapComplementaryInformationsDataInHavenBagMessage()
{
}

public MapComplementaryInformationsDataInHavenBagMessage(uint subAreaId, double mapId, Types.HouseInformations[] houses, Types.GameRolePlayActorInformations[] actors, Types.InteractiveElement[] interactiveElements, Types.StatedElement[] statedElements, Types.MapObstacle[] obstacles, Types.FightCommonInformations[] fights, bool hasAggressiveMonsters, Types.FightStartingPositions fightStartPositions, Types.CharacterMinimalInformations ownerInformations, sbyte theme, sbyte roomId, sbyte maxRoomId)
         : base(subAreaId, mapId, houses, actors, interactiveElements, statedElements, obstacles, fights, hasAggressiveMonsters, fightStartPositions)
        {
            this.ownerInformations = ownerInformations;
            this.theme = theme;
            this.roomId = roomId;
            this.maxRoomId = maxRoomId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            ownerInformations.Serialize(writer);
            writer.WriteSbyte(theme);
            writer.WriteSbyte(roomId);
            writer.WriteSbyte(maxRoomId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            ownerInformations = new Types.CharacterMinimalInformations();
            ownerInformations.Deserialize(reader);
            theme = reader.ReadSbyte();
            roomId = reader.ReadSbyte();
            maxRoomId = reader.ReadSbyte();
            

}


}


}