


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GuildRankMinimalInformation
{

public const short Id = 9298;
public virtual short TypeId
{
    get { return Id; }
}

public uint id;
        public string name;
        

public GuildRankMinimalInformation()
{
}

public GuildRankMinimalInformation(uint id, string name)
        {
            this.id = id;
            this.name = name;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)id);
            writer.WriteUTF(name);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhInt();
            name = reader.ReadUTF();
            

}


}


}