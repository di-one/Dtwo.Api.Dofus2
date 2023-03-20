


















// Generated on 01/22/2023 17:43:03
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class FightResultMutantListEntry : FightResultFighterListEntry
{

public const short Id = 7849;
public override short TypeId
{
    get { return Id; }
}

public uint level;
        

public FightResultMutantListEntry()
{
}

public FightResultMutantListEntry(uint outcome, sbyte wave, Types.FightLoot rewards, double id, bool alive, uint level)
         : base(outcome, wave, rewards, id, alive)
        {
            this.level = level;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)level);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            level = reader.ReadVarUhShort();
            

}


}


}