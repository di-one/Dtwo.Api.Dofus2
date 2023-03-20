


















// Generated on 01/22/2023 17:42:38
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameActionFightNoSpellCastMessage : Dofus2Message
{

public const uint Id = 6772;
public override uint MessageId
{
    get { return Id; }
}

public uint spellLevelId;
        

public GameActionFightNoSpellCastMessage()
{
}

public GameActionFightNoSpellCastMessage(uint spellLevelId)
        {
            this.spellLevelId = spellLevelId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)spellLevelId);
            

}

public override void Deserialize(IDataReader reader)
{

spellLevelId = reader.ReadVarUhInt();
            

}


}


}