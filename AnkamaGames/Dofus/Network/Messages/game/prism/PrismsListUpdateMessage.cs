


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PrismsListUpdateMessage : PrismsListMessage
{

public const uint Id = 7529;
public override uint MessageId
{
    get { return Id; }
}



public PrismsListUpdateMessage()
{
}

public PrismsListUpdateMessage(Types.PrismSubareaEmptyInfo[] prisms)
         : base(prisms)
        {
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}