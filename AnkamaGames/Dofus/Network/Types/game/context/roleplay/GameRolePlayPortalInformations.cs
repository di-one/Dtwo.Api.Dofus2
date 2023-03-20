


















// Generated on 01/22/2023 17:43:05
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GameRolePlayPortalInformations : GameRolePlayActorInformations
{

public const short Id = 7029;
public override short TypeId
{
    get { return Id; }
}

public Types.PortalInformation portal;
        

public GameRolePlayPortalInformations()
{
}

public GameRolePlayPortalInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, Types.PortalInformation portal)
         : base(contextualId, disposition, look)
        {
            this.portal = portal;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(portal.TypeId);
            portal.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            portal = ProtocolTypeManager.GetInstance<Types.PortalInformation>(reader.ReadUShort());
            portal.Deserialize(reader);
            

}


}


}