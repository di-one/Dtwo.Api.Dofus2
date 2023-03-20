


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GuildLevelUpActivity : GuildLogbookEntryBasicInformation
{

public const short Id = 118;
public override short TypeId
{
    get { return Id; }
}

public byte newGuildLevel;
        

public GuildLevelUpActivity()
{
}

public GuildLevelUpActivity(uint id, double date, byte newGuildLevel)
         : base(id, date)
        {
            this.newGuildLevel = newGuildLevel;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteByte(newGuildLevel);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            newGuildLevel = reader.ReadByte();
            

}


}


}