


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BreachBonusMessage : Dofus2Message
{

public const uint Id = 4510;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectEffectInteger bonus;
        

public BreachBonusMessage()
{
}

public BreachBonusMessage(Types.ObjectEffectInteger bonus)
        {
            this.bonus = bonus;
        }
        

public override void Serialize(IDataWriter writer)
{

bonus.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

bonus = new Types.ObjectEffectInteger();
            bonus.Deserialize(reader);
            

}


}


}