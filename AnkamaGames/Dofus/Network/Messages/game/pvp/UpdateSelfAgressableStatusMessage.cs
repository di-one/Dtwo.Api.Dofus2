


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class UpdateSelfAgressableStatusMessage : Dofus2Message
{

public const uint Id = 9898;
public override uint MessageId
{
    get { return Id; }
}

public sbyte status;
        public int probationTime;
        

public UpdateSelfAgressableStatusMessage()
{
}

public UpdateSelfAgressableStatusMessage(sbyte status, int probationTime)
        {
            this.status = status;
            this.probationTime = probationTime;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(status);
            writer.WriteInt(probationTime);
            

}

public override void Deserialize(IDataReader reader)
{

status = reader.ReadSbyte();
            probationTime = reader.ReadInt();
            

}


}


}