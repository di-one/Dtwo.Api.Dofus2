


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class PresetsContainerPreset : Preset
{

public const short Id = 5978;
public override short TypeId
{
    get { return Id; }
}

public Types.Preset[] presets;
        

public PresetsContainerPreset()
{
}

public PresetsContainerPreset(short id, Types.Preset[] presets)
         : base(id)
        {
            this.presets = presets;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)presets.Length);
            foreach (var entry in presets)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            presets = new Types.Preset[limit];
            for (int i = 0; i < limit; i++)
            {
                 presets[i] = ProtocolTypeManager.GetInstance<Types.Preset>(reader.ReadUShort());
                 presets[i].Deserialize(reader);
            }
            

}


}


}