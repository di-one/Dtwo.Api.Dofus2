


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class KnownZaapListMessage : Dofus2Message
{

public const uint Id = 2113;
public override uint MessageId
{
    get { return Id; }
}

public double[] destinations;
        

public KnownZaapListMessage()
{
}

public KnownZaapListMessage(double[] destinations)
        {
            this.destinations = destinations;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)destinations.Length);
            foreach (var entry in destinations)
            {
                 writer.WriteDouble(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            destinations = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 destinations[i] = reader.ReadDouble();
            }
            

}


}


}