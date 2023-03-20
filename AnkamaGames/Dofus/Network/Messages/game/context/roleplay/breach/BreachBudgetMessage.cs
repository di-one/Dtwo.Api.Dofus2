


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BreachBudgetMessage : Dofus2Message
{

public const uint Id = 9185;
public override uint MessageId
{
    get { return Id; }
}

public uint bugdet;
        

public BreachBudgetMessage()
{
}

public BreachBudgetMessage(uint bugdet)
        {
            this.bugdet = bugdet;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)bugdet);
            

}

public override void Deserialize(IDataReader reader)
{

bugdet = reader.ReadVarUhInt();
            

}


}


}