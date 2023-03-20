


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class EntitiesPreset : Preset
{

public const short Id = 6291;
public override short TypeId
{
    get { return Id; }
}

public short iconId;
        public uint[] entityIds;
        

public EntitiesPreset()
{
}

public EntitiesPreset(short id, short iconId, uint[] entityIds)
         : base(id)
        {
            this.iconId = iconId;
            this.entityIds = entityIds;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(iconId);
            writer.WriteShort((short)entityIds.Length);
            foreach (var entry in entityIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            iconId = reader.ReadShort();
            var limit = (ushort)reader.ReadUShort();
            entityIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 entityIds[i] = reader.ReadVarUhShort();
            }
            

}


}


}