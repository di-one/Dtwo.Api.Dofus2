


















// Generated on 01/22/2023 17:42:43
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameFightNewRoundMessage : Dofus2Message
{

public const uint Id = 1995;
public override uint MessageId
{
    get { return Id; }
}

public uint roundNumber;
        

public GameFightNewRoundMessage()
{
}

public GameFightNewRoundMessage(uint roundNumber)
        {
            this.roundNumber = roundNumber;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)roundNumber);
            

}

public override void Deserialize(IDataReader reader)
{

roundNumber = reader.ReadVarUhInt();
            

}


}


}