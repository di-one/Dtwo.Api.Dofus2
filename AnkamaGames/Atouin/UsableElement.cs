using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Atouin
{
    public class UsableElement
    {
        public UsableElement(int cellId, InteractiveElement element, List<InteractiveElementSkill> skills)
        {
            CellId = cellId;
            Element = element;
            Skills = skills;
        }

        public int CellId { get; private set; }
        public InteractiveElement Element { get; private set; }
        public List<InteractiveElementSkill> Skills { get; private set; }
    }
}
