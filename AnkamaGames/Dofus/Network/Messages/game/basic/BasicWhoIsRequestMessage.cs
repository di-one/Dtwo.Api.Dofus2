


















// Generated on 01/22/2023 17:42:40
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BasicWhoIsRequestMessage : Dofus2Message
{

public const uint Id = 5910;
public override uint MessageId
{
    get { return Id; }
}

public bool verbose;
        public Types.AbstractPlayerSearchInformation target;
        

public BasicWhoIsRequestMessage()
{
}

public BasicWhoIsRequestMessage(bool verbose, Types.AbstractPlayerSearchInformation target)
        {
            this.verbose = verbose;
            this.target = target;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(verbose);
            writer.WriteShort(target.TypeId);
            target.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

verbose = reader.ReadBoolean();
            target = ProtocolTypeManager.GetInstance<Types.AbstractPlayerSearchInformation>(reader.ReadUShort());
            target.Deserialize(reader);
            

}


}


}