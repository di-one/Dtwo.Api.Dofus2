


















// Generated on 01/22/2023 17:43:02
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class AchievementStartedObjective : AchievementObjective
{

public const short Id = 6750;
public override short TypeId
{
    get { return Id; }
}

public uint value;
        

public AchievementStartedObjective()
{
}

public AchievementStartedObjective(uint id, uint maxValue, uint value)
         : base(id, maxValue)
        {
            this.value = value;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)value);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadVarUhShort();
            

}


}


}