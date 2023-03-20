


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PrismInfoJoinLeaveRequestMessage : Dofus2Message
{

public const uint Id = 9586;
public override uint MessageId
{
    get { return Id; }
}

public bool join;
        

public PrismInfoJoinLeaveRequestMessage()
{
}

public PrismInfoJoinLeaveRequestMessage(bool join)
        {
            this.join = join;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(join);
            

}

public override void Deserialize(IDataReader reader)
{

join = reader.ReadBoolean();
            

}


}


}