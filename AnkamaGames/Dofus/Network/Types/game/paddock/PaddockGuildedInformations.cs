


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class PaddockGuildedInformations : PaddockBuyableInformations
{

public const short Id = 1931;
public override short TypeId
{
    get { return Id; }
}

public bool deserted;
        public Types.GuildInformations guildInfo;
        

public PaddockGuildedInformations()
{
}

public PaddockGuildedInformations(double price, bool locked, bool deserted, Types.GuildInformations guildInfo)
         : base(price, locked)
        {
            this.deserted = deserted;
            this.guildInfo = guildInfo;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(deserted);
            guildInfo.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            deserted = reader.ReadBoolean();
            guildInfo = new Types.GuildInformations();
            guildInfo.Deserialize(reader);
            

}


}


}