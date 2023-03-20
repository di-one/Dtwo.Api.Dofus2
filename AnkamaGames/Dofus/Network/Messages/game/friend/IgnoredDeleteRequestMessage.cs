


















// Generated on 01/22/2023 17:42:52
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class IgnoredDeleteRequestMessage : Dofus2Message
{

public const uint Id = 7964;
public override uint MessageId
{
    get { return Id; }
}

public int accountId;
        public bool session;
        

public IgnoredDeleteRequestMessage()
{
}

public IgnoredDeleteRequestMessage(int accountId, bool session)
        {
            this.accountId = accountId;
            this.session = session;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(accountId);
            writer.WriteBoolean(session);
            

}

public override void Deserialize(IDataReader reader)
{

accountId = reader.ReadInt();
            session = reader.ReadBoolean();
            

}


}


}