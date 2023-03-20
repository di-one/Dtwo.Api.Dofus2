


















// Generated on 01/22/2023 17:43:03
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GameContextActorInformations : GameContextActorPositionInformations
{

public const short Id = 6154;
public override short TypeId
{
    get { return Id; }
}

public Types.EntityLook look;
        

public GameContextActorInformations()
{
}

public GameContextActorInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look)
         : base(contextualId, disposition)
        {
            this.look = look;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            look.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            look = new Types.EntityLook();
            look.Deserialize(reader);
            

}


}


}