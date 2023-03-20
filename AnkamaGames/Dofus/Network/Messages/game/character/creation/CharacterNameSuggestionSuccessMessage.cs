


















// Generated on 01/22/2023 17:42:41
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class CharacterNameSuggestionSuccessMessage : Dofus2Message
{

public const uint Id = 5468;
public override uint MessageId
{
    get { return Id; }
}

public string suggestion;
        

public CharacterNameSuggestionSuccessMessage()
{
}

public CharacterNameSuggestionSuccessMessage(string suggestion)
        {
            this.suggestion = suggestion;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(suggestion);
            

}

public override void Deserialize(IDataReader reader)
{

suggestion = reader.ReadUTF();
            

}


}


}