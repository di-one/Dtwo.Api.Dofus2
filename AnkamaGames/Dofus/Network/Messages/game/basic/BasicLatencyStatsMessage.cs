


















// Generated on 01/22/2023 17:42:40
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BasicLatencyStatsMessage : Dofus2Message
{

public const uint Id = 8383;
public override uint MessageId
{
    get { return Id; }
}

public ushort latency;
        public uint sampleCount;
        public uint max;
        

public BasicLatencyStatsMessage()
{
}

public BasicLatencyStatsMessage(ushort latency, uint sampleCount, uint max)
        {
            this.latency = latency;
            this.sampleCount = sampleCount;
            this.max = max;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUShort(latency);
            writer.WriteVarShort((int)sampleCount);
            writer.WriteVarShort((int)max);
            

}

public override void Deserialize(IDataReader reader)
{

latency = reader.ReadUShort();
            sampleCount = reader.ReadVarUhShort();
            max = reader.ReadVarUhShort();
            

}


}


}