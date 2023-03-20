


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class ObjectEffects
{

public const short Id = 3634;
public virtual short TypeId
{
    get { return Id; }
}

public Types.ObjectEffect[] effects;
        

public ObjectEffects()
{
}

public ObjectEffects(Types.ObjectEffect[] effects)
        {
            this.effects = effects;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteShort((short)effects.Length);
            foreach (var entry in effects)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public virtual void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            effects = new Types.ObjectEffect[limit];
            for (int i = 0; i < limit; i++)
            {
                 effects[i] = ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadUShort());
                 effects[i].Deserialize(reader);
            }
            

}


}


}