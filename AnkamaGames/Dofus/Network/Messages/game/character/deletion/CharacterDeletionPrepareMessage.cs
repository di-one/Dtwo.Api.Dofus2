


















// Generated on 01/22/2023 17:42:41
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class CharacterDeletionPrepareMessage : Dofus2Message
{

public const uint Id = 9781;
public override uint MessageId
{
    get { return Id; }
}

public double characterId;
        public string characterName;
        public string secretQuestion;
        public bool needSecretAnswer;
        

public CharacterDeletionPrepareMessage()
{
}

public CharacterDeletionPrepareMessage(double characterId, string characterName, string secretQuestion, bool needSecretAnswer)
        {
            this.characterId = characterId;
            this.characterName = characterName;
            this.secretQuestion = secretQuestion;
            this.needSecretAnswer = needSecretAnswer;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(characterId);
            writer.WriteUTF(characterName);
            writer.WriteUTF(secretQuestion);
            writer.WriteBoolean(needSecretAnswer);
            

}

public override void Deserialize(IDataReader reader)
{

characterId = reader.ReadVarUhLong();
            characterName = reader.ReadUTF();
            secretQuestion = reader.ReadUTF();
            needSecretAnswer = reader.ReadBoolean();
            

}


}


}