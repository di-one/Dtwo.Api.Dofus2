


















// Generated on 01/22/2023 17:42:53
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildUpdateChestTabRequestMessage : Dofus2Message
{

public const uint Id = 5668;
public override uint MessageId
{
    get { return Id; }
}

public Types.UpdatedStorageTabInformation tab;
        

public GuildUpdateChestTabRequestMessage()
{
}

public GuildUpdateChestTabRequestMessage(Types.UpdatedStorageTabInformation tab)
        {
            this.tab = tab;
        }
        

public override void Serialize(IDataWriter writer)
{

tab.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

tab = new Types.UpdatedStorageTabInformation();
            tab.Deserialize(reader);
            

}


}


}