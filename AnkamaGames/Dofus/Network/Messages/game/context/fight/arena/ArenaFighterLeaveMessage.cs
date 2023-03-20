


















// Generated on 01/22/2023 17:42:44
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ArenaFighterLeaveMessage : Dofus2Message
{

public const uint Id = 7444;
public override uint MessageId
{
    get { return Id; }
}

public Types.CharacterBasicMinimalInformations leaver;
        

public ArenaFighterLeaveMessage()
{
}

public ArenaFighterLeaveMessage(Types.CharacterBasicMinimalInformations leaver)
        {
            this.leaver = leaver;
        }
        

public override void Serialize(IDataWriter writer)
{

leaver.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

leaver = new Types.CharacterBasicMinimalInformations();
            leaver.Deserialize(reader);
            

}


}


}