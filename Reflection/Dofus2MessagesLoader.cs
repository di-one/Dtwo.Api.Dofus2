using System.Reflection;
using Dtwo.API.Dofus2.Network.Messages;
using Dtwo.API.DofusBase.Reflection;

namespace Dtwo.API.Dofus2.Reflection
{
    public class Dofus2MessagesLoader : MessagesLoader<Dofus2Message>
    {
        public static Dofus2MessagesLoader Instance { get; private set; }
        protected override Assembly m_assembly => Assembly.GetAssembly(typeof(Dofus2Message));

        public Dofus2MessagesLoader()
        {
            Instance = this;
        }
    }
}
