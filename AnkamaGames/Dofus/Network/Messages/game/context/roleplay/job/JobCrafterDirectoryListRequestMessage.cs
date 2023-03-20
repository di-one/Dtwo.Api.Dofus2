


















// Generated on 01/22/2023 17:42:48
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class JobCrafterDirectoryListRequestMessage : Dofus2Message
{

public const uint Id = 585;
public override uint MessageId
{
    get { return Id; }
}

public sbyte jobId;
        

public JobCrafterDirectoryListRequestMessage()
{
}

public JobCrafterDirectoryListRequestMessage(sbyte jobId)
        {
            this.jobId = jobId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(jobId);
            

}

public override void Deserialize(IDataReader reader)
{

jobId = reader.ReadSbyte();
            

}


}


}