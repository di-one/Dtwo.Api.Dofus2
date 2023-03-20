


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ItemForPresetUpdateMessage : Dofus2Message
{

public const uint Id = 5361;
public override uint MessageId
{
    get { return Id; }
}

public short presetId;
        public Types.ItemForPreset presetItem;
        

public ItemForPresetUpdateMessage()
{
}

public ItemForPresetUpdateMessage(short presetId, Types.ItemForPreset presetItem)
        {
            this.presetId = presetId;
            this.presetItem = presetItem;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(presetId);
            presetItem.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

presetId = reader.ReadShort();
            presetItem = new Types.ItemForPreset();
            presetItem.Deserialize(reader);
            

}


}


}