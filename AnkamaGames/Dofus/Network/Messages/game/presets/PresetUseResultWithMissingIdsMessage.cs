


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PresetUseResultWithMissingIdsMessage : PresetUseResultMessage
{

public const uint Id = 6022;
public override uint MessageId
{
    get { return Id; }
}

public uint[] missingIds;
        

public PresetUseResultWithMissingIdsMessage()
{
}

public PresetUseResultWithMissingIdsMessage(short presetId, sbyte code, uint[] missingIds)
         : base(presetId, code)
        {
            this.missingIds = missingIds;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)missingIds.Length);
            foreach (var entry in missingIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            missingIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 missingIds[i] = reader.ReadVarUhShort();
            }
            

}


}


}