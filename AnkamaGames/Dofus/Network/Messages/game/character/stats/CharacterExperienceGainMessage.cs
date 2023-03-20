


















// Generated on 01/22/2023 17:42:41
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class CharacterExperienceGainMessage : Dofus2Message
{

public const uint Id = 7492;
public override uint MessageId
{
    get { return Id; }
}

public double experienceCharacter;
        public double experienceMount;
        public double experienceGuild;
        public double experienceIncarnation;
        

public CharacterExperienceGainMessage()
{
}

public CharacterExperienceGainMessage(double experienceCharacter, double experienceMount, double experienceGuild, double experienceIncarnation)
        {
            this.experienceCharacter = experienceCharacter;
            this.experienceMount = experienceMount;
            this.experienceGuild = experienceGuild;
            this.experienceIncarnation = experienceIncarnation;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(experienceCharacter);
            writer.WriteVarLong(experienceMount);
            writer.WriteVarLong(experienceGuild);
            writer.WriteVarLong(experienceIncarnation);
            

}

public override void Deserialize(IDataReader reader)
{

experienceCharacter = reader.ReadVarUhLong();
            experienceMount = reader.ReadVarUhLong();
            experienceGuild = reader.ReadVarUhLong();
            experienceIncarnation = reader.ReadVarUhLong();
            

}


}


}