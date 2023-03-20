


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GoldItem : Item
{

public const short Id = 7613;
public override short TypeId
{
    get { return Id; }
}

public double sum;
        

public GoldItem()
{
}

public GoldItem(double sum)
        {
            this.sum = sum;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(sum);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            sum = reader.ReadVarUhLong();
            

}


}


}