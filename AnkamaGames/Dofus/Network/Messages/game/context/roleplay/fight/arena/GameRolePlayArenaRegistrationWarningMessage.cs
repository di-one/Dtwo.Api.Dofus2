


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameRolePlayArenaRegistrationWarningMessage : Dofus2Message
{

public const uint Id = 3691;
public override uint MessageId
{
    get { return Id; }
}

public int battleMode;
        

public GameRolePlayArenaRegistrationWarningMessage()
{
}

public GameRolePlayArenaRegistrationWarningMessage(int battleMode)
        {
            this.battleMode = battleMode;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(battleMode);
            

}

public override void Deserialize(IDataReader reader)
{

battleMode = reader.ReadInt();
            

}


}


}