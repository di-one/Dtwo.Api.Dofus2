


















// Generated on 01/22/2023 17:43:05
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class JobBookSubscription
{

public const short Id = 1331;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte jobId;
        public bool subscribed;
        

public JobBookSubscription()
{
}

public JobBookSubscription(sbyte jobId, bool subscribed)
        {
            this.jobId = jobId;
            this.subscribed = subscribed;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(jobId);
            writer.WriteBoolean(subscribed);
            

}

public virtual void Deserialize(IDataReader reader)
{

jobId = reader.ReadSbyte();
            subscribed = reader.ReadBoolean();
            

}


}


}