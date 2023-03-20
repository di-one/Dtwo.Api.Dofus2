


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GuildLogbookEntryBasicInformation
{

public const short Id = 9953;
public virtual short TypeId
{
    get { return Id; }
}

public uint id;
        public double date;
        

public GuildLogbookEntryBasicInformation()
{
}

public GuildLogbookEntryBasicInformation(uint id, double date)
        {
            this.id = id;
            this.date = date;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)id);
            writer.WriteDouble(date);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhInt();
            date = reader.ReadDouble();
            

}


}


}