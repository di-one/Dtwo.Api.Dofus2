


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameRolePlayArenaRegistrationStatusMessage : Dofus2Message
{

public const uint Id = 9108;
public override uint MessageId
{
    get { return Id; }
}

public bool registered;
        public sbyte step;
        public int battleMode;
        

public GameRolePlayArenaRegistrationStatusMessage()
{
}

public GameRolePlayArenaRegistrationStatusMessage(bool registered, sbyte step, int battleMode)
        {
            this.registered = registered;
            this.step = step;
            this.battleMode = battleMode;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(registered);
            writer.WriteSbyte(step);
            writer.WriteInt(battleMode);
            

}

public override void Deserialize(IDataReader reader)
{

registered = reader.ReadBoolean();
            step = reader.ReadSbyte();
            battleMode = reader.ReadInt();
            

}


}


}