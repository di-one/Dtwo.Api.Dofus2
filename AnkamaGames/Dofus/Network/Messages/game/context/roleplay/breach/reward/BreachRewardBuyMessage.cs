


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BreachRewardBuyMessage : Dofus2Message
{

public const uint Id = 896;
public override uint MessageId
{
    get { return Id; }
}

public uint id;
        

public BreachRewardBuyMessage()
{
}

public BreachRewardBuyMessage(uint id)
        {
            this.id = id;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)id);
            

}

public override void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhInt();
            

}


}


}