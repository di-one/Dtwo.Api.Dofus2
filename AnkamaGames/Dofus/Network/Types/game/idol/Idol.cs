


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class Idol
{

public const short Id = 1259;
public virtual short TypeId
{
    get { return Id; }
}

public uint id;
        public uint xpBonusPercent;
        public uint dropBonusPercent;
        

public Idol()
{
}

public Idol(uint id, uint xpBonusPercent, uint dropBonusPercent)
        {
            this.id = id;
            this.xpBonusPercent = xpBonusPercent;
            this.dropBonusPercent = dropBonusPercent;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)id);
            writer.WriteVarShort((int)xpBonusPercent);
            writer.WriteVarShort((int)dropBonusPercent);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhShort();
            xpBonusPercent = reader.ReadVarUhShort();
            dropBonusPercent = reader.ReadVarUhShort();
            

}


}


}