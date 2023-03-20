


















// Generated on 01/22/2023 17:42:40
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class NumericWhoIsMessage : Dofus2Message
{

public const uint Id = 4988;
public override uint MessageId
{
    get { return Id; }
}

public double playerId;
        public int accountId;
        

public NumericWhoIsMessage()
{
}

public NumericWhoIsMessage(double playerId, int accountId)
        {
            this.playerId = playerId;
            this.accountId = accountId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(playerId);
            writer.WriteInt(accountId);
            

}

public override void Deserialize(IDataReader reader)
{

playerId = reader.ReadVarUhLong();
            accountId = reader.ReadInt();
            

}


}


}