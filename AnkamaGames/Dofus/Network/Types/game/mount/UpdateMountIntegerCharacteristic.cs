


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class UpdateMountIntegerCharacteristic : UpdateMountCharacteristic
{

public const short Id = 3041;
public override short TypeId
{
    get { return Id; }
}

public int value;
        

public UpdateMountIntegerCharacteristic()
{
}

public UpdateMountIntegerCharacteristic(sbyte type, int value)
         : base(type)
        {
            this.value = value;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(value);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadInt();
            

}


}


}