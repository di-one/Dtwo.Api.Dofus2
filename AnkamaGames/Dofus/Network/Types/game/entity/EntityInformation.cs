


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class EntityInformation
{

public const short Id = 7875;
public virtual short TypeId
{
    get { return Id; }
}

public uint id;
        public uint experience;
        public bool status;
        

public EntityInformation()
{
}

public EntityInformation(uint id, uint experience, bool status)
        {
            this.id = id;
            this.experience = experience;
            this.status = status;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)id);
            writer.WriteVarInt((int)experience);
            writer.WriteBoolean(status);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhShort();
            experience = reader.ReadVarUhInt();
            status = reader.ReadBoolean();
            

}


}


}