


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PresetsMessage : Dofus2Message
{

public const uint Id = 7904;
public override uint MessageId
{
    get { return Id; }
}

public Types.Preset[] presets;
        

public PresetsMessage()
{
}

public PresetsMessage(Types.Preset[] presets)
        {
            this.presets = presets;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)presets.Length);
            foreach (var entry in presets)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

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