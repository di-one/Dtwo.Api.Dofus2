using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Atouin
{
    public class BlendedGraphicalElementData : NormalGraphicalElementData
    {
        public string BlendMode { get; private set; }

        public BlendedGraphicalElementData(int elementId, int elementType) : base(elementId, elementType)
        {
        }

        public override void FromRaw(BigEndianReader reader, int version)
        {
            base.FromRaw(reader, version);

            int blendModeLength = reader.ReadInt();
            BlendMode = reader.ReadUTFBytes((ushort)blendModeLength);
        }
    }
}
