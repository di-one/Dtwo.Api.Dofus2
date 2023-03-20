


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class ObjectEffect
{

public const short Id = 2375;
public virtual short TypeId
{
    get { return Id; }
}

public uint actionId;
        

public ObjectEffect()
{
}

public ObjectEffect(uint actionId)
        {
            this.actionId = actionId;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)actionId);
            

}

public virtual void Deserialize(IDataReader reader)
{

actionId = reader.ReadVarUhShort();
            

}


}


}