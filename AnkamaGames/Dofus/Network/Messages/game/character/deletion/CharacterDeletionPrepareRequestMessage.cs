


















// Generated on 01/22/2023 17:42:41
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class CharacterDeletionPrepareRequestMessage : Dofus2Message
{

public const uint Id = 2431;
public override uint MessageId
{
    get { return Id; }
}

public double characterId;
        

public CharacterDeletionPrepareRequestMessage()
{
}

public CharacterDeletionPrepareRequestMessage(double characterId)
        {
            this.characterId = characterId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(characterId);
            

}

public override void Deserialize(IDataReader reader)
{

characterId = reader.ReadVarUhLong();
            

}


}


}