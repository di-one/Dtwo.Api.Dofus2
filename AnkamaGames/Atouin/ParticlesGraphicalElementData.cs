using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Atouin
{
    public class ParticlesGraphicalElementData : GraphicalElementData
    {
        public int ScriptId { get; set; }

        public ParticlesGraphicalElementData(int elementId, int elementType) : base(elementId, elementType)
        {
        }

        public override void FromRaw(BigEndianReader reader, int version)
        {
            ScriptId = reader.ReadShort();
        }

    }
}
