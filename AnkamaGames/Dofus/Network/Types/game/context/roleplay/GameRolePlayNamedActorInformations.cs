


















// Generated on 01/22/2023 17:43:05
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GameRolePlayNamedActorInformations : GameRolePlayActorInformations
{

public const short Id = 4532;
public override short TypeId
{
    get { return Id; }
}

public string name;
        

public GameRolePlayNamedActorInformations()
{
}

public GameRolePlayNamedActorInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, string name)
         : base(contextualId, disposition, look)
        {
            this.name = name;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            

}


}


}