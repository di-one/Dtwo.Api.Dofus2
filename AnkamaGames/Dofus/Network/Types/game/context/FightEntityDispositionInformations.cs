


















// Generated on 01/22/2023 17:43:03
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class FightEntityDispositionInformations : EntityDispositionInformations
{

public const short Id = 1876;
public override short TypeId
{
    get { return Id; }
}

public double carryingCharacterId;
        

public FightEntityDispositionInformations()
{
}

public FightEntityDispositionInformations(short cellId, sbyte direction, double carryingCharacterId)
         : base(cellId, direction)
        {
            this.carryingCharacterId = carryingCharacterId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(carryingCharacterId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            carryingCharacterId = reader.ReadDouble();
            

}


}


}