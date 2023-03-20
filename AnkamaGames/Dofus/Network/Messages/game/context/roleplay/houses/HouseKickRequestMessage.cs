


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HouseKickRequestMessage : Dofus2Message
{

public const uint Id = 4453;
public override uint MessageId
{
    get { return Id; }
}

public double id;
        

public HouseKickRequestMessage()
{
}

public HouseKickRequestMessage(double id)
        {
            this.id = id;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(id);
            

}

public override void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhLong();
            

}


}


}