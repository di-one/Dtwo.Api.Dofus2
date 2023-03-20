


















// Generated on 01/22/2023 17:42:48
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AbstractPartyMessage : Dofus2Message
{

public const uint Id = 1856;
public override uint MessageId
{
    get { return Id; }
}

public uint partyId;
        

public AbstractPartyMessage()
{
}

public AbstractPartyMessage(uint partyId)
        {
            this.partyId = partyId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)partyId);
            

}

public override void Deserialize(IDataReader reader)
{

partyId = reader.ReadVarUhInt();
            

}


}


}