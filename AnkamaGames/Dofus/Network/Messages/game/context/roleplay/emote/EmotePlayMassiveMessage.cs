


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class EmotePlayMassiveMessage : EmotePlayAbstractMessage
{

public const uint Id = 77;
public override uint MessageId
{
    get { return Id; }
}

public double[] actorIds;
        

public EmotePlayMassiveMessage()
{
}

public EmotePlayMassiveMessage(ushort emoteId, double emoteStartTime, double[] actorIds)
         : base(emoteId, emoteStartTime)
        {
            this.actorIds = actorIds;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)actorIds.Length);
            foreach (var entry in actorIds)
            {
                 writer.WriteDouble(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            actorIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 actorIds[i] = reader.ReadDouble();
            }
            

}


}


}