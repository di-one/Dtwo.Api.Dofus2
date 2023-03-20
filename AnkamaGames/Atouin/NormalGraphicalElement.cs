using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Atouin
{
    public class NormalGraphicalElementData : GraphicalElementData
    {
        public int GfxId { get; private set; }
        public int Height { get; private set; }
        public bool HorizontalSymmetry { get; private set; }
        public float SizeX { get; private set; }
        public float SizeY { get; private set; }
        public float OriginX { get; private set; }
        public float OriginY { get; private set; }

        public NormalGraphicalElementData(int elementId, int elementType) : base(elementId, elementType)
        {
            
        }


        public override void FromRaw(BigEndianReader reader, int version)
        {
            try
            {
                GfxId = reader.ReadInt();
                Height = reader.ReadSByte();
                HorizontalSymmetry = reader.ReadBoolean();

                OriginX = reader.ReadShort();
                OriginY = reader.ReadShort();

                SizeX = reader.ReadShort();
                SizeY = reader.ReadShort();

            }
            catch(Exception ex)
            {
                Console.WriteLine("Init normal graphical element error " + ex.Message);
            }
        }

    }
}
