


















// Generated on 01/22/2023 17:42:43
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameMapMovementMessage : Dofus2Message
{

public const uint Id = 7425;
public override uint MessageId
{
    get { return Id; }
}

public short[] keyMovements;
        public short forcedDirection;
        public double actorId;
        

public GameMapMovementMessage()
{
}

public GameMapMovementMessage(short[] keyMovements, short forcedDirection, double actorId)
        {
            this.keyMovements = keyMovements;
            this.forcedDirection = forcedDirection;
            this.actorId = actorId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)keyMovements.Length);
            foreach (var entry in keyMovements)
            {
                 writer.WriteShort(entry);
            }
            writer.WriteShort(forcedDirection);
            writer.WriteDouble(actorId);
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            keyMovements = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 keyMovements[i] = reader.ReadShort();
            }
            forcedDirection = reader.ReadShort();
            actorId = reader.ReadDouble();
            

}


}


}