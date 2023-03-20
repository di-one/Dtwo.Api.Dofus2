


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class IconNamedPresetSaveRequestMessage : IconPresetSaveRequestMessage
{

public const uint Id = 2233;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        public sbyte type;
        

public IconNamedPresetSaveRequestMessage()
{
}

public IconNamedPresetSaveRequestMessage(short presetId, sbyte symbolId, bool updateData, string name, sbyte type)
         : base(presetId, symbolId, updateData)
        {
            this.name = name;
            this.type = type;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            writer.WriteSbyte(type);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            type = reader.ReadSbyte();
            

}


}


}