


















// Generated on 01/22/2023 17:43:05
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class ObjectItemInRolePlay
{

public const short Id = 7139;
public virtual short TypeId
{
    get { return Id; }
}

public uint cellId;
        public uint objectGID;
        

public ObjectItemInRolePlay()
{
}

public ObjectItemInRolePlay(uint cellId, uint objectGID)
        {
            this.cellId = cellId;
            this.objectGID = objectGID;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)cellId);
            writer.WriteVarInt((int)objectGID);
            

}

public virtual void Deserialize(IDataReader reader)
{

cellId = reader.ReadVarUhShort();
            objectGID = reader.ReadVarUhInt();
            

}


}


}