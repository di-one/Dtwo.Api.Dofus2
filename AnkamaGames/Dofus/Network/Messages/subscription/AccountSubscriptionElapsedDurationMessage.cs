


















// Generated on 01/22/2023 17:43:02
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AccountSubscriptionElapsedDurationMessage : Dofus2Message
{

public const uint Id = 3364;
public override uint MessageId
{
    get { return Id; }
}

public double subscriptionElapsedDuration;
        

public AccountSubscriptionElapsedDurationMessage()
{
}

public AccountSubscriptionElapsedDurationMessage(double subscriptionElapsedDuration)
        {
            this.subscriptionElapsedDuration = subscriptionElapsedDuration;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(subscriptionElapsedDuration);
            

}

public override void Deserialize(IDataReader reader)
{

subscriptionElapsedDuration = reader.ReadDouble();
            

}


}


}