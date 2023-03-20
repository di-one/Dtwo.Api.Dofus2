


















// Generated on 01/22/2023 17:42:41
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class CharacterLevelUpMessage : Dofus2Message
{

public const uint Id = 1846;
public override uint MessageId
{
    get { return Id; }
}

public uint newLevel;
        

public CharacterLevelUpMessage()
{
}

public CharacterLevelUpMessage(uint newLevel)
        {
            this.newLevel = newLevel;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)newLevel);
            

}

public override void Deserialize(IDataReader reader)
{

newLevel = reader.ReadVarUhShort();
            

}


}


}