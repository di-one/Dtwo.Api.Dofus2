


















// Generated on 01/22/2023 17:43:03
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class CharacterMinimalGuildPublicInformations : CharacterMinimalInformations
{

public const short Id = 9695;
public override short TypeId
{
    get { return Id; }
}

public Types.GuildRankPublicInformation rank;
        

public CharacterMinimalGuildPublicInformations()
{
}

public CharacterMinimalGuildPublicInformations(double id, string name, uint level, Types.GuildRankPublicInformation rank)
         : base(id, name, level)
        {
            this.rank = rank;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            rank.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            rank = new Types.GuildRankPublicInformation();
            rank.Deserialize(reader);
            

}


}


}