


















// Generated on 01/22/2023 17:43:02
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class StatisticDataBoolean : StatisticData
{

public const short Id = 2517;
public override short TypeId
{
    get { return Id; }
}

public bool value;
        

public StatisticDataBoolean()
{
}

public StatisticDataBoolean(bool value)
        {
            this.value = value;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(value);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadBoolean();
            

}


}


}