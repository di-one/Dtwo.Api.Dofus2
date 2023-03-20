


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class UpdateMountCharacteristic
{

public const short Id = 9715;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte type;
        

public UpdateMountCharacteristic()
{
}

public UpdateMountCharacteristic(sbyte type)
        {
            this.type = type;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(type);
            

}

public virtual void Deserialize(IDataReader reader)
{

type = reader.ReadSbyte();
            

}


}


}