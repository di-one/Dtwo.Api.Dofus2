


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PresetSavedMessage : Dofus2Message
{

public const uint Id = 2124;
public override uint MessageId
{
    get { return Id; }
}

public short presetId;
        public Types.Preset preset;
        

public PresetSavedMessage()
{
}

public PresetSavedMessage(short presetId, Types.Preset preset)
        {
            this.presetId = presetId;
            this.preset = preset;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(presetId);
            writer.WriteShort(preset.TypeId);
            preset.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

presetId = reader.ReadShort();
            preset = ProtocolTypeManager.GetInstance<Types.Preset>(reader.ReadUShort());
            preset.Deserialize(reader);
            

}


}


}