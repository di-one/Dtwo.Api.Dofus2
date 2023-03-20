


















// Generated on 01/22/2023 17:42:38
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameActionFightTackledMessage : AbstractGameActionMessage
{

public const uint Id = 6478;
public override uint MessageId
{
    get { return Id; }
}

public double[] tacklersIds;
        

public GameActionFightTackledMessage()
{
}

public GameActionFightTackledMessage(uint actionId, double sourceId, double[] tacklersIds)
         : base(actionId, sourceId)
        {
            this.tacklersIds = tacklersIds;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)tacklersIds.Length);
            foreach (var entry in tacklersIds)
            {
                 writer.WriteDouble(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            tacklersIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 tacklersIds[i] = reader.ReadDouble();
            }
            

}


}


}