


















// Generated on 01/22/2023 17:42:40
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AlterationRemovedMessage : Dofus2Message
{

public const uint Id = 6499;
public override uint MessageId
{
    get { return Id; }
}

public Types.AlterationInfo alteration;
        

public AlterationRemovedMessage()
{
}

public AlterationRemovedMessage(Types.AlterationInfo alteration)
        {
            this.alteration = alteration;
        }
        

public override void Serialize(IDataWriter writer)
{

alteration.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

alteration = new Types.AlterationInfo();
            alteration.Deserialize(reader);
            

}


}


}