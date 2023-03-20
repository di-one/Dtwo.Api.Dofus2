


















// Generated on 01/22/2023 17:42:48
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class JobCrafterDirectoryRemoveMessage : Dofus2Message
{

public const uint Id = 8883;
public override uint MessageId
{
    get { return Id; }
}

public sbyte jobId;
        public double playerId;
        

public JobCrafterDirectoryRemoveMessage()
{
}

public JobCrafterDirectoryRemoveMessage(sbyte jobId, double playerId)
        {
            this.jobId = jobId;
            this.playerId = playerId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(jobId);
            writer.WriteVarLong(playerId);
            

}

public override void Deserialize(IDataReader reader)
{

jobId = reader.ReadSbyte();
            playerId = reader.ReadVarUhLong();
            

}


}


}