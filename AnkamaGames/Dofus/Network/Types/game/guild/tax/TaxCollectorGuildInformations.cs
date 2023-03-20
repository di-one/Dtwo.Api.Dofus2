


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class TaxCollectorGuildInformations : TaxCollectorComplementaryInformations
{

public const short Id = 3219;
public override short TypeId
{
    get { return Id; }
}

public Types.BasicGuildInformations guild;
        

public TaxCollectorGuildInformations()
{
}

public TaxCollectorGuildInformations(Types.BasicGuildInformations guild)
        {
            this.guild = guild;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            guild.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            guild = new Types.BasicGuildInformations();
            guild.Deserialize(reader);
            

}


}


}