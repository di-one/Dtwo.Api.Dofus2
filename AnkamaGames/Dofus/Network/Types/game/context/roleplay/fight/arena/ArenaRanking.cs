


















// Generated on 01/22/2023 17:43:05
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class ArenaRanking
{

public const short Id = 5644;
public virtual short TypeId
{
    get { return Id; }
}

public uint rank;
        public uint bestRank;
        

public ArenaRanking()
{
}

public ArenaRanking(uint rank, uint bestRank)
        {
            this.rank = rank;
            this.bestRank = bestRank;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)rank);
            writer.WriteVarShort((int)bestRank);
            

}

public virtual void Deserialize(IDataReader reader)
{

rank = reader.ReadVarUhShort();
            bestRank = reader.ReadVarUhShort();
            

}


}


}