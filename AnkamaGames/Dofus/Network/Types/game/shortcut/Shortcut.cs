


















// Generated on 01/22/2023 17:43:08
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class Shortcut
{

public const short Id = 3762;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte slot;
        

public Shortcut()
{
}

public Shortcut(sbyte slot)
        {
            this.slot = slot;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(slot);
            

}

public virtual void Deserialize(IDataReader reader)
{

slot = reader.ReadSbyte();
            

}


}


}