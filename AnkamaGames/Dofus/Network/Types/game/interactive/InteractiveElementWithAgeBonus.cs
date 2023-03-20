


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class InteractiveElementWithAgeBonus : InteractiveElement
{

public const short Id = 2757;
public override short TypeId
{
    get { return Id; }
}

public short ageBonus;
        

public InteractiveElementWithAgeBonus()
{
}

public InteractiveElementWithAgeBonus(int elementId, int elementTypeId, Types.InteractiveElementSkill[] enabledSkills, Types.InteractiveElementSkill[] disabledSkills, bool onCurrentMap, short ageBonus)
         : base(elementId, elementTypeId, enabledSkills, disabledSkills, onCurrentMap)
        {
            this.ageBonus = ageBonus;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(ageBonus);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            ageBonus = reader.ReadShort();
            

}


}


}