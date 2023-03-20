


















// Generated on 01/22/2023 17:42:53
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildPaddockRemovedMessage : Dofus2Message
{

public const uint Id = 5128;
public override uint MessageId
{
    get { return Id; }
}

public double paddockId;
        

public GuildPaddockRemovedMessage()
{
}

public GuildPaddockRemovedMessage(double paddockId)
        {
            this.paddockId = paddockId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(paddockId);
            

}

public override void Deserialize(IDataReader reader)
{

paddockId = reader.ReadDouble();
            

}


}


}