


















// Generated on 01/22/2023 17:42:41
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ForgettableSpellEquipmentSlotsMessage : Dofus2Message
{

public const uint Id = 4599;
public override uint MessageId
{
    get { return Id; }
}

public int quantity;
        

public ForgettableSpellEquipmentSlotsMessage()
{
}

public ForgettableSpellEquipmentSlotsMessage(int quantity)
        {
            this.quantity = quantity;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)quantity);
            

}

public override void Deserialize(IDataReader reader)
{

quantity = reader.ReadVarShort();
            

}


}


}