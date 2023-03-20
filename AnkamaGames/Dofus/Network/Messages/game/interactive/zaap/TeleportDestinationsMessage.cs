


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class TeleportDestinationsMessage : Dofus2Message
{

public const uint Id = 1545;
public override uint MessageId
{
    get { return Id; }
}

public sbyte type;
        public Types.TeleportDestination[] destinations;
        

public TeleportDestinationsMessage()
{
}

public TeleportDestinationsMessage(sbyte type, Types.TeleportDestination[] destinations)
        {
            this.type = type;
            this.destinations = destinations;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(type);
            writer.WriteShort((short)destinations.Length);
            foreach (var entry in destinations)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

type = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            destinations = new Types.TeleportDestination[limit];
            for (int i = 0; i < limit; i++)
            {
                 destinations[i] = new Types.TeleportDestination();
                 destinations[i].Deserialize(reader);
            }
            

}


}


}