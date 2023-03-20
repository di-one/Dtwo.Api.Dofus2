


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GuildUnlockNewTabActivity : GuildLogbookEntryBasicInformation
{

public const short Id = 7590;
public override short TypeId
{
    get { return Id; }
}



public GuildUnlockNewTabActivity()
{
}

public GuildUnlockNewTabActivity(uint id, double date)
         : base(id, date)
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