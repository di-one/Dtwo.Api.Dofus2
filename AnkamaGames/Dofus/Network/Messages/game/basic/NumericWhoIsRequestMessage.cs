


















// Generated on 01/22/2023 17:42:40
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class NumericWhoIsRequestMessage : Dofus2Message
{

public const uint Id = 7392;
public override uint MessageId
{
    get { return Id; }
}

public double playerId;
        

public NumericWhoIsRequestMessage()
{
}

public NumericWhoIsRequestMessage(double playerId)
        {
            this.playerId = playerId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(playerId);
            

}

public override void Deserialize(IDataReader reader)
{

playerId = reader.ReadVarUhLong();
            

}


}


}