


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class InvalidPresetsMessage : Dofus2Message
{

public const uint Id = 9117;
public override uint MessageId
{
    get { return Id; }
}

public short[] presetIds;
        

public InvalidPresetsMessage()
{
}

public InvalidPresetsMessage(short[] presetIds)
        {
            this.presetIds = presetIds;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)presetIds.Length);
            foreach (var entry in presetIds)
            {
                 writer.WriteShort(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            presetIds = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 presetIds[i] = reader.ReadShort();
            }
            

}


}


}