


















// Generated on 01/22/2023 17:43:08
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class BufferInformation
{

public const short Id = 6969;
public virtual short TypeId
{
    get { return Id; }
}

public double id;
        public double amount;
        

public BufferInformation()
{
}

public BufferInformation(double id, double amount)
        {
            this.id = id;
            this.amount = amount;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarLong(id);
            writer.WriteVarLong(amount);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhLong();
            amount = reader.ReadVarUhLong();
            

}


}


}