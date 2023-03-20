


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildFightLeaveRequestMessage : Dofus2Message
{

public const uint Id = 6954;
public override uint MessageId
{
    get { return Id; }
}

public double taxCollectorId;
        public double characterId;
        

public GuildFightLeaveRequestMessage()
{
}

public GuildFightLeaveRequestMessage(double taxCollectorId, double characterId)
        {
            this.taxCollectorId = taxCollectorId;
            this.characterId = characterId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(taxCollectorId);
            writer.WriteVarLong(characterId);
            

}

public override void Deserialize(IDataReader reader)
{

taxCollectorId = reader.ReadDouble();
            characterId = reader.ReadVarUhLong();
            

}


}


}