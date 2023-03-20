


















// Generated on 01/22/2023 17:43:02
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class ServerSessionConstant
{

public const short Id = 9098;
public virtual short TypeId
{
    get { return Id; }
}

public uint id;
        

public ServerSessionConstant()
{
}

public ServerSessionConstant(uint id)
        {
            this.id = id;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)id);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhShort();
            

}


}


}