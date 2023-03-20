


















// Generated on 01/22/2023 17:43:04
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class FightTeamMemberCharacterInformations : FightTeamMemberInformations
{

public const short Id = 9478;
public override short TypeId
{
    get { return Id; }
}

public string name;
        public uint level;
        

public FightTeamMemberCharacterInformations()
{
}

public FightTeamMemberCharacterInformations(double id, string name, uint level)
         : base(id)
        {
            this.name = name;
            this.level = level;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            writer.WriteVarShort((int)level);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            level = reader.ReadVarUhShort();
            

}


}


}