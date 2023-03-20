


















// Generated on 01/22/2023 17:42:52
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildCharacsUpgradeRequestMessage : Dofus2Message
{

public const uint Id = 3359;
public override uint MessageId
{
    get { return Id; }
}

public sbyte charaTypeTarget;
        

public GuildCharacsUpgradeRequestMessage()
{
}

public GuildCharacsUpgradeRequestMessage(sbyte charaTypeTarget)
        {
            this.charaTypeTarget = charaTypeTarget;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(charaTypeTarget);
            

}

public override void Deserialize(IDataReader reader)
{

charaTypeTarget = reader.ReadSbyte();
            

}


}


}