


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AlignmentWarEffortProgressionMessage : Dofus2Message
{

public const uint Id = 1983;
public override uint MessageId
{
    get { return Id; }
}

public Types.AlignmentWarEffortInformation[] effortProgressions;
        

public AlignmentWarEffortProgressionMessage()
{
}

public AlignmentWarEffortProgressionMessage(Types.AlignmentWarEffortInformation[] effortProgressions)
        {
            this.effortProgressions = effortProgressions;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)effortProgressions.Length);
            foreach (var entry in effortProgressions)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            effortProgressions = new Types.AlignmentWarEffortInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 effortProgressions[i] = new Types.AlignmentWarEffortInformation();
                 effortProgressions[i].Deserialize(reader);
            }
            

}


}


}