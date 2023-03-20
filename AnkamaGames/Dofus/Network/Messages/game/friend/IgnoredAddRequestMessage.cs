


















// Generated on 01/22/2023 17:42:52
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class IgnoredAddRequestMessage : Dofus2Message
{

public const uint Id = 1080;
public override uint MessageId
{
    get { return Id; }
}

public Types.AbstractPlayerSearchInformation target;
        public bool session;
        

public IgnoredAddRequestMessage()
{
}

public IgnoredAddRequestMessage(Types.AbstractPlayerSearchInformation target, bool session)
        {
            this.target = target;
            this.session = session;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(target.TypeId);
            target.Serialize(writer);
            writer.WriteBoolean(session);
            

}

public override void Deserialize(IDataReader reader)
{

target = ProtocolTypeManager.GetInstance<Types.AbstractPlayerSearchInformation>(reader.ReadUShort());
            target.Deserialize(reader);
            session = reader.ReadBoolean();
            

}


}


}