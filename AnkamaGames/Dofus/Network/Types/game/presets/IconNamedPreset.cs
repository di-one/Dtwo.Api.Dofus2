


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class IconNamedPreset : PresetsContainerPreset
{

public const short Id = 5740;
public override short TypeId
{
    get { return Id; }
}

public short iconId;
        public string name;
        

public IconNamedPreset()
{
}

public IconNamedPreset(short id, Types.Preset[] presets, short iconId, string name)
         : base(id, presets)
        {
            this.iconId = iconId;
            this.name = name;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(iconId);
            writer.WriteUTF(name);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            iconId = reader.ReadShort();
            name = reader.ReadUTF();
            

}


}


}