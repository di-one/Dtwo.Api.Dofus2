


















// Generated on 01/22/2023 17:43:03
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class CharacterMinimalAllianceInformations : CharacterMinimalGuildInformations
{

public const short Id = 9153;
public override short TypeId
{
    get { return Id; }
}

public Types.BasicAllianceInformations alliance;
        

public CharacterMinimalAllianceInformations()
{
}

public CharacterMinimalAllianceInformations(double id, string name, uint level, Types.EntityLook entityLook, sbyte breed, Types.BasicGuildInformations guild, Types.BasicAllianceInformations alliance)
         : base(id, name, level, entityLook, breed, guild)
        {
            this.alliance = alliance;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            alliance.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            alliance = new Types.BasicAllianceInformations();
            alliance.Deserialize(reader);
            

}


}


}