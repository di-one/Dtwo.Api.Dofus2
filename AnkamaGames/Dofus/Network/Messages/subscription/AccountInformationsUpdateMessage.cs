


















// Generated on 01/22/2023 17:43:01
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AccountInformationsUpdateMessage : Dofus2Message
{

public const uint Id = 5396;
public override uint MessageId
{
    get { return Id; }
}

public double subscriptionEndDate;
        

public AccountInformationsUpdateMessage()
{
}

public AccountInformationsUpdateMessage(double subscriptionEndDate)
        {
            this.subscriptionEndDate = subscriptionEndDate;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(subscriptionEndDate);
            

}

public override void Deserialize(IDataReader reader)
{

subscriptionEndDate = reader.ReadDouble();
            

}


}


}