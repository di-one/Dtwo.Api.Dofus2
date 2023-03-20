


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GuildRankInformation : GuildRankMinimalInformation
{

public const short Id = 8982;
public override short TypeId
{
    get { return Id; }
}

public uint order;
        public uint gfxId;
        public bool modifiable;
        public uint[] rights;
        

public GuildRankInformation()
{
}

public GuildRankInformation(uint id, string name, uint order, uint gfxId, bool modifiable, uint[] rights)
         : base(id, name)
        {
            this.order = order;
            this.gfxId = gfxId;
            this.modifiable = modifiable;
            this.rights = rights;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)order);
            writer.WriteVarInt((int)gfxId);
            writer.WriteBoolean(modifiable);
            writer.WriteShort((short)rights.Length);
            foreach (var entry in rights)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            order = reader.ReadVarUhInt();
            gfxId = reader.ReadVarUhInt();
            modifiable = reader.ReadBoolean();
            var limit = (ushort)reader.ReadUShort();
            rights = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 rights[i] = reader.ReadVarUhInt();
            }
            

}


}


}