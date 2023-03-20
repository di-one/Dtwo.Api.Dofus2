


















// Generated on 01/22/2023 17:42:44
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BreachGameFightEndMessage : GameFightEndMessage
{

public const uint Id = 9349;
public override uint MessageId
{
    get { return Id; }
}

public int budget;
        

public BreachGameFightEndMessage()
{
}

public BreachGameFightEndMessage(int duration, int rewardRate, short lootShareLimitMalus, Types.FightResultListEntry[] results, Types.NamedPartyTeamWithOutcome[] namedPartyTeamsOutcomes, int budget)
         : base(duration, rewardRate, lootShareLimitMalus, results, namedPartyTeamsOutcomes)
        {
            this.budget = budget;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(budget);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            budget = reader.ReadInt();
            

}


}


}