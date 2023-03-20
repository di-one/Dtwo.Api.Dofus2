


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class IgnoredInformations : AbstractContactInformations
{

public const short Id = 3964;
public override short TypeId
{
    get { return Id; }
}



public IgnoredInformations()
{
}

public IgnoredInformations(int accountId, Types.AccountTagInformation accountTag)
         : base(accountId, accountTag)
        {
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}