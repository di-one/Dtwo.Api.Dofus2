


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class ItemForPreset
{

public const short Id = 3514;
public virtual short TypeId
{
    get { return Id; }
}

public short position;
        public uint objGid;
        public uint objUid;
        

public ItemForPreset()
{
}

public ItemForPreset(short position, uint objGid, uint objUid)
        {
            this.position = position;
            this.objGid = objGid;
            this.objUid = objUid;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteShort(position);
            writer.WriteVarInt((int)objGid);
            writer.WriteVarInt((int)objUid);
            

}

public virtual void Deserialize(IDataReader reader)
{

position = reader.ReadShort();
            objGid = reader.ReadVarUhInt();
            objUid = reader.ReadVarUhInt();
            

}


}


}