


















// Generated on 01/22/2023 17:43:03
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class AbstractCharacterInformation
{

public const short Id = 7441;
public virtual short TypeId
{
    get { return Id; }
}

public double id;
        

public AbstractCharacterInformation()
{
}

public AbstractCharacterInformation(double id)
        {
            this.id = id;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarLong(id);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhLong();
            

}


}


}