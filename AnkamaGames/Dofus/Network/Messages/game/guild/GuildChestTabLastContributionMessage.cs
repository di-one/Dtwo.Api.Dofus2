


















// Generated on 01/22/2023 17:42:52
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildChestTabLastContributionMessage : Dofus2Message
{

public const uint Id = 2135;
public override uint MessageId
{
    get { return Id; }
}

public double lastContributionDate;
        

public GuildChestTabLastContributionMessage()
{
}

public GuildChestTabLastContributionMessage(double lastContributionDate)
        {
            this.lastContributionDate = lastContributionDate;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(lastContributionDate);
            

}

public override void Deserialize(IDataReader reader)
{

lastContributionDate = reader.ReadDouble();
            

}


}


}