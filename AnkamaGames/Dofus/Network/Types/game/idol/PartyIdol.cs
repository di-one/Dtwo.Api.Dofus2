


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class PartyIdol : Idol
{

public const short Id = 8979;
public override short TypeId
{
    get { return Id; }
}

public double[] ownersIds;
        

public PartyIdol()
{
}

public PartyIdol(uint id, uint xpBonusPercent, uint dropBonusPercent, double[] ownersIds)
         : base(id, xpBonusPercent, dropBonusPercent)
        {
            this.ownersIds = ownersIds;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)ownersIds.Length);
            foreach (var entry in ownersIds)
            {
                 writer.WriteVarLong(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            ownersIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 ownersIds[i] = reader.ReadVarUhLong();
            }
            

}


}


}