using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Atouin
{
    public class GraphicalElement : BasicElement
    {
        // Fields
        public int Altitude;
        public int ElementId;
        public ColorMultiplicator FinalTeint;
        public ColorMultiplicator Hue;
        public int Identifier;
        public double OffsetX;
        public double OffsetY;
        public double PixelOffsetX;
        public double PixelOffsetY;
        public ColorMultiplicator Shadow;

        public override int ElementType { get; protected set; } = (int)Type.Graphical;

        // Methods
        internal override void Init(IDataReader Reader, int MapVersion)
        {
            ElementId = Convert.ToInt32(Reader.ReadUInt());
            Hue = new ColorMultiplicator(Reader.ReadByte(), Reader.ReadByte(), Reader.ReadByte());
            Shadow = new ColorMultiplicator(Reader.ReadByte(), Reader.ReadByte(), Reader.ReadByte());
            if (MapVersion <= 4)
            {
                OffsetX = Reader.ReadByte();
                OffsetY = Reader.ReadByte();
                PixelOffsetX = (OffsetX * 43);
                PixelOffsetY = (OffsetY * 21.5);
            }
            else
            {
                PixelOffsetX = Reader.ReadShort();
                PixelOffsetY = Reader.ReadShort();
                OffsetX = (PixelOffsetX / 43);
                OffsetY = (PixelOffsetY / 21.5);
            }
            Altitude = Reader.ReadByte();
            Identifier = (int)Reader.ReadUInt();
        }
    }
}
