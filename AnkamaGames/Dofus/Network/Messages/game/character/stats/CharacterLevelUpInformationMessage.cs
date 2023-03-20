


















// Generated on 01/22/2023 17:42:41
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class CharacterLevelUpInformationMessage : CharacterLevelUpMessage
{

public const uint Id = 5824;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        public double id;
        

public CharacterLevelUpInformationMessage()
{
}

public CharacterLevelUpInformationMessage(uint newLevel, string name, double id)
         : base(newLevel)
        {
            this.name = name;
            this.id = id;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            writer.WriteVarLong(id);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            id = reader.ReadVarUhLong();
            

}


}


}