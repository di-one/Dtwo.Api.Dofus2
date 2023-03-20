


















// Generated on 01/22/2023 17:42:41
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class UpdateSpellModifierMessage : Dofus2Message
{

public const uint Id = 3555;
public override uint MessageId
{
    get { return Id; }
}

public double actorId;
        public Types.CharacterSpellModification spellModifier;
        

public UpdateSpellModifierMessage()
{
}

public UpdateSpellModifierMessage(double actorId, Types.CharacterSpellModification spellModifier)
        {
            this.actorId = actorId;
            this.spellModifier = spellModifier;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(actorId);
            spellModifier.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

actorId = reader.ReadDouble();
            spellModifier = new Types.CharacterSpellModification();
            spellModifier.Deserialize(reader);
            

}


}


}