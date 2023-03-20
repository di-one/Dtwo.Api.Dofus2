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
            Console.WriteLine("Layer init 1");
            if (MapVersion >= 9)
            {
                Console.WriteLine("Layer init 2");
                LayerId = Reader.ReadByte();
            }
            else
            {
                Console.WriteLine("Layer init 3");
                LayerId = Reader.ReadInt();
            }
            Console.WriteLine("Layer init 4");
            CellsCount = Reader.ReadShort();
            Console.WriteLine("Layer init 5 cell count : " + CellsCount);

            for (int i = 0; i < CellsCount; i++)
            {
                Cell item = new Cell();
                item.Init(Reader, MapVersion);
                Cells.Add(item);
            }
            Console.WriteLine("Layer init 6");
        }

        // Fields
        public List<Cell> Cells = new List<Cell>();
        public int CellsCount;
        public int LayerId;
    }
}
