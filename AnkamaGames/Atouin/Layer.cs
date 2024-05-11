using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Atouin
{
    public class Layer
    {
        public enum LayerType : int
        {
            Ground = 0,
            AdditionalGround = 1,
            Decor = 2,
            AdditionalDecor = 3
        }

        // Methods
        internal void Init(IDataReader Reader, int MapVersion)
        {
            if (MapVersion >= 9)
            {
                LayerId = Reader.ReadByte();
            }
            else
            {
                LayerId = Reader.ReadInt();
            }
            CellsCount = Reader.ReadShort();

            for (int i = 0; i < CellsCount; i++)
            {
                Cell item = new Cell();
                item.Init(Reader, MapVersion);
                Cells.Add(item);
            }
        }

        // Fields
        public List<Cell> Cells = new List<Cell>();
        public int CellsCount;
        public int LayerId;
    }
}
