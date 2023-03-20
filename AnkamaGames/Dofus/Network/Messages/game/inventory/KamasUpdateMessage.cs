


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class KamasUpdateMessage : Dofus2Message
{

public const uint Id = 4842;
public override uint MessageId
{
    get { return Id; }
}

public double kamasTotal;
        

public KamasUpdateMessage()
{
}

public KamasUpdateMessage(double kamasTotal)
        {
            this.kamasTotal = kamasTotal;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(kamasTotal);
            

}

public override void Deserialize(IDataReader reader)
{

kamasTotal = reader.ReadVarUhLong();
            

}


}


}