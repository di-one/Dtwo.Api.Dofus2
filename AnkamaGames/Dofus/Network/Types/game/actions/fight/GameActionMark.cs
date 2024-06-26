


















// Generated on 01/22/2023 17:43:02
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GameActionMark
{

public const short Id = 7942;
public virtual short TypeId
{
    get { return Id; }
}

public double markAuthorId;
        public sbyte markTeamId;
        public int markSpellId;
        public short markSpellLevel;
        public short markId;
        public sbyte markType;
        public short markimpactCell;
        public Types.GameActionMarkedCell[] cells;
        public bool active;
        

public GameActionMark()
{
}

public GameActionMark(double markAuthorId, sbyte markTeamId, int markSpellId, short markSpellLevel, short markId, sbyte markType, short markimpactCell, Types.GameActionMarkedCell[] cells, bool active)
        {
            this.markAuthorId = markAuthorId;
            this.markTeamId = markTeamId;
            this.markSpellId = markSpellId;
            this.markSpellLevel = markSpellLevel;
            this.markId = markId;
            this.markType = markType;
            this.markimpactCell = markimpactCell;
            this.cells = cells;
            this.active = active;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteDouble(markAuthorId);
            writer.WriteSbyte(markTeamId);
            writer.WriteInt(markSpellId);
            writer.WriteShort(markSpellLevel);
            writer.WriteShort(markId);
            writer.WriteSbyte(markType);
            writer.WriteShort(markimpactCell);
            writer.WriteShort((short)cells.Length);
            foreach (var entry in cells)
            {
                 entry.Serialize(writer);
            }
            writer.WriteBoolean(active);
            

}

public virtual void Deserialize(IDataReader reader)
{

markAuthorId = reader.ReadDouble();
            markTeamId = reader.ReadSbyte();
            markSpellId = reader.ReadInt();
            markSpellLevel = reader.ReadShort();
            markId = reader.ReadShort();
            markType = reader.ReadSbyte();
            markimpactCell = reader.ReadShort();
            var limit = (ushort)reader.ReadUShort();
            cells = new Types.GameActionMarkedCell[limit];
            for (int i = 0; i < limit; i++)
            {
                 cells[i] = new Types.GameActionMarkedCell();
                 cells[i].Deserialize(reader);
            }
            active = reader.ReadBoolean();
            

}


}


}