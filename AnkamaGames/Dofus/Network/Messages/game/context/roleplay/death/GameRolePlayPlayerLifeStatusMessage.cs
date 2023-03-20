


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameRolePlayPlayerLifeStatusMessage : Dofus2Message
{

public const uint Id = 7815;
public override uint MessageId
{
    get { return Id; }
}

public sbyte state;
        public double phenixMapId;
        

public GameRolePlayPlayerLifeStatusMessage()
{
}

public GameRolePlayPlayerLifeStatusMessage(sbyte state, double phenixMapId)
        {
            this.state = state;
            this.phenixMapId = phenixMapId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(state);
            writer.WriteDouble(phenixMapId);
            

}

public override void Deserialize(IDataReader reader)
{

state = reader.ReadSbyte();
            phenixMapId = reader.ReadDouble();
            

}


}


}