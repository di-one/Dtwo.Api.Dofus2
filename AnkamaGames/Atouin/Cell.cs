using System.Numerics;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Atouin
{
    public class Cell
    {
        // Fields
        public int CellId;
        public List<BasicElement> Elements = new List<BasicElement>();
        public int ElementsCount;

        public void Init(IDataReader Reader, int MapVersion)
        {
            CellId = Reader.ReadShort();
            ElementsCount = Reader.ReadShort();
            for (int i = 0; i < ElementsCount; i++)
            {
                var el_type = Reader.ReadByte();
                BasicElement be = BasicElement.GetElementFromType(el_type);

                if (be != null)
                {
                    be.Init(Reader, MapVersion);
                    Elements.Add(be);
                }
            }
        }

        public Vector2 GetPixelCoords()
        {
            return GetCellPixelCoords(CellId);
        }

        public static Vector2 GetCellPixelCoords(int cellId)
        {
            Vector2 pos = GetCellCoords(cellId);
            pos.X = pos.X * 86 + (pos.Y % 2 == 1 ? 43 : 0);
            pos.Y *= 21.5f;

            return pos;
        }

        public static Vector2 GetCellCoords(int cellId)
        {
            Vector2 pos = new Vector2();

            pos.X = cellId % 14;
            pos.Y = (float)Math.Floor((double)(cellId / 14));

            return pos;
        }
    }
}
