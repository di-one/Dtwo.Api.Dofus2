


















// Generated on 01/22/2023 17:43:08
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class ShortcutEntitiesPreset : Shortcut
{

public const short Id = 8093;
public override short TypeId
{
    get { return Id; }
}

public short presetId;
        

public ShortcutEntitiesPreset()
{
}

public ShortcutEntitiesPreset(sbyte slot, short presetId)
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