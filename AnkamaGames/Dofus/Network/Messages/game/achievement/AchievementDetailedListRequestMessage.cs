


















// Generated on 01/22/2023 17:42:37
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AchievementDetailedListRequestMessage : Dofus2Message
{

public const uint Id = 4355;
public override uint MessageId
{
    get { return Id; }
}

public uint categoryId;
        

public AchievementDetailedListRequestMessage()
{
}

public AchievementDetailedListRequestMessage(uint categoryId)
        {
            this.categoryId = categoryId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)categoryId);
            

}

public override void Deserialize(IDataReader reader)
{

categoryId = reader.ReadVarUhShort();
            

}


}


}