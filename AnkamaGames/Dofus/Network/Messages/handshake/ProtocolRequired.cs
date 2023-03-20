


















// Generated on 01/22/2023 17:43:01
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ProtocolRequired : Dofus2Message
{

public const uint Id = 4970;
public override uint MessageId
{
    get { return Id; }
}

public string version;
        

public ProtocolRequired()
{
}

public ProtocolRequired(string version)
        {
            this.version = version;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(version);
            

}

public override void Deserialize(IDataReader reader)
{

version = reader.ReadUTF();
            

}


}


}