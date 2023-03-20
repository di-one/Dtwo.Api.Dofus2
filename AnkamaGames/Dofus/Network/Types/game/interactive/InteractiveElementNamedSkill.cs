


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class InteractiveElementNamedSkill : InteractiveElementSkill
{

public const short Id = 7491;
public override short TypeId
{
    get { return Id; }
}

public uint nameId;
        

public InteractiveElementNamedSkill()
{
}

public InteractiveElementNamedSkill(uint skillId, int skillInstanceUid, uint nameId)
         : base(skillId, skillInstanceUid)
        {
            this.nameId = nameId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)nameId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            nameId = reader.ReadVarUhInt();
            

}


}


}