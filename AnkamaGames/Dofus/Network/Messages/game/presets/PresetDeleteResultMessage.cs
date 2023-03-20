


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PresetDeleteResultMessage : Dofus2Message
{

public const uint Id = 718;
public override uint MessageId
{
    get { return Id; }
}

public short presetId;
        public sbyte code;
        

public PresetDeleteResultMessage()
{
}

public PresetDeleteResultMessage(short presetId, sbyte code)
        {
            this.presetId = presetId;
            this.code = code;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(presetId);
            writer.WriteSbyte(code);
            

}

public override void Deserialize(IDataReader reader)
{

presetId = reader.ReadShort();
            code = reader.ReadSbyte();
            

}


}


}