


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HouseLockFromInsideRequestMessage : LockableChangeCodeMessage
{

public const uint Id = 8494;
public override uint MessageId
{
    get { return Id; }
}



public HouseLockFromInsideRequestMessage()
{
}

public HouseLockFromInsideRequestMessage(string code)
         : base(code)
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