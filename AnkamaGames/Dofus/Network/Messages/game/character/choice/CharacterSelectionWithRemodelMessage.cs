


















// Generated on 01/22/2023 17:42:41
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class CharacterSelectionWithRemodelMessage : CharacterSelectionMessage
{

public const uint Id = 2978;
public override uint MessageId
{
    get { return Id; }
}

public Types.RemodelingInformation remodel;
        

public CharacterSelectionWithRemodelMessage()
{
}

public CharacterSelectionWithRemodelMessage(double id, Types.RemodelingInformation remodel)
         : base(id)
        {
            this.remodel = remodel;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            remodel.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            remodel = new Types.RemodelingInformation();
            remodel.Deserialize(reader);
            

}


}


}