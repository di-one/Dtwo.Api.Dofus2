using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Atouin
{
    public class AnimatedGraphicalElementData : NormalGraphicalElementData
    {
        public int MinDelay { get; private set; }
        public int MaxDelay { get; private set; }

        public AnimatedGraphicalElementData(int elementId, int elementType) : base(elementId, elementType)
        {
            
        }

        public override void FromRaw(BigEndianReader reader, int version)
        {
            base.FromRaw(reader, version);

            if (version == 4)
            {
                MinDelay = reader.ReadInt();
                MaxDelay = reader.ReadInt();
            }
        }
    }
}
