


















// Generated on 01/22/2023 17:42:52
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildChestTabContributionsMessage : Dofus2Message
{

public const uint Id = 6766;
public override uint MessageId
{
    get { return Id; }
}

public Types.Contribution[] contributions;
        

public GuildChestTabContributionsMessage()
{
}

public GuildChestTabContributionsMessage(Types.Contribution[] contributions)
        {
            this.contributions = contributions;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)contributions.Length);
            foreach (var entry in contributions)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            contributions = new Types.Contribution[limit];
            for (int i = 0; i < limit; i++)
            {
                 contributions[i] = new Types.Contribution();
                 contributions[i].Deserialize(reader);
            }
            

}


}


}