


















// Generated on 01/22/2023 17:43:08
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class ShortcutObjectPreset : ShortcutObject
{

public const short Id = 7965;
public override short TypeId
{
    get { return Id; }
}

public short presetId;
        

public ShortcutObjectPreset()
{
}

public ShortcutObjectPreset(sbyte slot, short presetId)
         : base(slot)
        {
            this.presetId = presetId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(presetId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            presetId = reader.ReadShort();
            

}


}


}