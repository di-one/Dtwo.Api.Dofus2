


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class IconPresetSaveRequestMessage : Dofus2Message
{

public const uint Id = 717;
public override uint MessageId
{
    get { return Id; }
}

public short presetId;
        public sbyte symbolId;
        public bool updateData;
        

public IconPresetSaveRequestMessage()
{
}

public IconPresetSaveRequestMessage(short presetId, sbyte symbolId, bool updateData)
        {
            this.presetId = presetId;
            this.symbolId = symbolId;
            this.updateData = updateData;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(presetId);
            writer.WriteSbyte(symbolId);
            writer.WriteBoolean(updateData);
            

}

public override void Deserialize(IDataReader reader)
{

presetId = reader.ReadShort();
            symbolId = reader.ReadSbyte();
            updateData = reader.ReadBoolean();
            

}


}


}