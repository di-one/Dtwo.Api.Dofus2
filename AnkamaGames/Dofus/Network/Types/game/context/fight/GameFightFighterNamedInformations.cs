


















// Generated on 01/22/2023 17:43:04
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GameFightFighterNamedInformations : GameFightFighterInformations
{

public const short Id = 6988;
public override short TypeId
{
    get { return Id; }
}

public string name;
        public Types.PlayerStatus status;
        public int leagueId;
        public int ladderPosition;
        public bool hiddenInPrefight;
        

public GameFightFighterNamedInformations()
{
}

public GameFightFighterNamedInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, Types.GameContextBasicSpawnInformation spawnInfo, sbyte wave, Types.GameFightCharacteristics stats, uint[] previousPositions, string name, Types.PlayerStatus status, int leagueId, int ladderPosition, bool hiddenInPrefight)
         : base(contextualId, disposition, look, spawnInfo, wave, stats, previousPositions)
        {
            this.name = name;
            this.status = status;
            this.leagueId = leagueId;
            this.ladderPosition = ladderPosition;
            this.hiddenInPrefight = hiddenInPrefight;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            status.Serialize(writer);
            writer.WriteVarShort((int)leagueId);
            writer.WriteInt(ladderPosition);
            writer.WriteBoolean(hiddenInPrefight);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            status = new Types.PlayerStatus();
            status.Deserialize(reader);
            leagueId = reader.ReadVarShort();
            ladderPosition = reader.ReadInt();
            hiddenInPrefight = reader.ReadBoolean();
            

}


}


}