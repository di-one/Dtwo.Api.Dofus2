


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class Preset
{

public const short Id = 4929;
public virtual short TypeId
{
    get { return Id; }
}

public short id;
        

public Preset()
{
}

public Preset(short id)
        {
            this.id = id;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteShort(id);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadShort();
            

}


}


}