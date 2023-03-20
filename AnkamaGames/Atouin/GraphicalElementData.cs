using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Atouin
{
    public class GraphicalElementData
    {
        public int Id;
        public int Type;

        public GraphicalElementData(int elementId, int elementType)
        {
            Id = elementId;
            Type = elementType;
        }

        public virtual void FromRaw(BigEndianReader reader, int version)
        {

        }
    }
}
