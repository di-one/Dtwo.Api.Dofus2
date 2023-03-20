


















// Generated on 01/22/2023 17:43:03
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class DebtInformation
{

public const short Id = 2854;
public virtual short TypeId
{
    get { return Id; }
}

public double id;
        public double timestamp;
        

public DebtInformation()
{
}

public DebtInformation(double id, double timestamp)
        {
            this.id = id;
            this.timestamp = timestamp;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteDouble(id);
            writer.WriteDouble(timestamp);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadDouble();
            timestamp = reader.ReadDouble();
            

}


}


}