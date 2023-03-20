


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class UpdateGuildRankRequestMessage : Dofus2Message
{

public const uint Id = 7592;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildRankInformation rank;
        

public UpdateGuildRankRequestMessage()
{
}

public UpdateGuildRankRequestMessage(Types.GuildRankInformation rank)
        {
            this.rank = rank;
        }
        

public override void Serialize(IDataWriter writer)
{

rank.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

rank = new Types.GuildRankInformation();
            rank.Deserialize(reader);
            

}


}


}