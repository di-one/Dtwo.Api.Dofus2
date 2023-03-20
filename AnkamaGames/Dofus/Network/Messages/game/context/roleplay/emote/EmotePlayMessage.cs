


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class EmotePlayMessage : EmotePlayAbstractMessage
{

public const uint Id = 4251;
public override uint MessageId
{
    get { return Id; }
}

public double actorId;
        public int accountId;
        

public EmotePlayMessage()
{
}

public EmotePlayMessage(ushort emoteId, double emoteStartTime, double actorId, int accountId)
         : base(emoteId, emoteStartTime)
        {
            this.actorId = actorId;
            this.accountId = accountId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(actorId);
            writer.WriteInt(accountId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            actorId = reader.ReadDouble();
            accountId = reader.ReadInt();
            

}


}


}