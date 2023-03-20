


















// Generated on 01/22/2023 17:42:44
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class SlaveNoLongerControledMessage : Dofus2Message
{

public const uint Id = 4651;
public override uint MessageId
{
    get { return Id; }
}

public double masterId;
        public double slaveId;
        

public SlaveNoLongerControledMessage()
{
}

public SlaveNoLongerControledMessage(double masterId, double slaveId)
        {
            this.masterId = masterId;
            this.slaveId = slaveId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(masterId);
            writer.WriteDouble(slaveId);
            

}

public override void Deserialize(IDataReader reader)
{

masterId = reader.ReadDouble();
            slaveId = reader.ReadDouble();
            

}


}


}