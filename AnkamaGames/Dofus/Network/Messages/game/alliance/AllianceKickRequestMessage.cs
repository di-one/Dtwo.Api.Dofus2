


















// Generated on 01/22/2023 17:42:39
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AllianceKickRequestMessage : Dofus2Message
{

public const uint Id = 4496;
public override uint MessageId
{
    get { return Id; }
}

public uint kickedId;
        

public AllianceKickRequestMessage()
{
}

public AllianceKickRequestMessage(uint kickedId)
        {
            this.kickedId = kickedId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)kickedId);
            

}

public override void Deserialize(IDataReader reader)
{

kickedId = reader.ReadVarUhInt();
            

}


}


}