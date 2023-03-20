


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PresetUseRequestMessage : Dofus2Message
{

public const uint Id = 1682;
public override uint MessageId
{
    get { return Id; }
}

public short presetId;
        

public PresetUseRequestMessage()
{
}

public PresetUseRequestMessage(short presetId)
        {
            this.presetId = presetId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(presetId);
            

}

public override void Deserialize(IDataReader reader)
{

presetId = reader.ReadShort();
            

}


}


}