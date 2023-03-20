


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class ObjectEffectInteger : ObjectEffect
{

public const short Id = 5142;
public override short TypeId
{
    get { return Id; }
}

public uint value;
        

public ObjectEffectInteger()
{
}

public ObjectEffectInteger(uint actionId, uint value)
         : base(actionId)
        {
            this.value = value;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)value);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadVarUhInt();
            

}


}


}