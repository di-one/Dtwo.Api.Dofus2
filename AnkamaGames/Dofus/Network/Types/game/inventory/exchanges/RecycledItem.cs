


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class RecycledItem
{

public const short Id = 3353;
public virtual short TypeId
{
    get { return Id; }
}

public uint id;
        public uint qty;
        

public RecycledItem()
{
}

public RecycledItem(uint id, uint qty)
        {
            this.id = id;
            this.qty = qty;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)id);
            writer.WriteUInt(qty);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhInt();
            qty = reader.ReadUInt();
            

}


}


}