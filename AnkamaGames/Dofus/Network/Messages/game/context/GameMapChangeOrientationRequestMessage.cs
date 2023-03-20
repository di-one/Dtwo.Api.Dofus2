


















// Generated on 01/22/2023 17:42:43
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameMapChangeOrientationRequestMessage : Dofus2Message
{

public const uint Id = 5516;
public override uint MessageId
{
    get { return Id; }
}

public sbyte direction;
        

public GameMapChangeOrientationRequestMessage()
{
}

public GameMapChangeOrientationRequestMessage(sbyte direction)
        {
            this.direction = direction;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(direction);
            

}

public override void Deserialize(IDataReader reader)
{

direction = reader.ReadSbyte();
            

}


}


}