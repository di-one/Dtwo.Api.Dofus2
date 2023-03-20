


















// Generated on 01/22/2023 17:43:04
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GameFightFighterMonsterLightInformations : GameFightFighterLightInformations
{

public const short Id = 6010;
public override short TypeId
{
    get { return Id; }
}

public uint creatureGenericId;
        

public GameFightFighterMonsterLightInformations()
{
}

public GameFightFighterMonsterLightInformations(bool sex, bool alive, double id, sbyte wave, uint level, sbyte breed, uint creatureGenericId)
         : base(sex, alive, id, wave, level, breed)
        {
            this.creatureGenericId = creatureGenericId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)creatureGenericId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            creatureGenericId = reader.ReadVarUhShort();
            

}


}


}