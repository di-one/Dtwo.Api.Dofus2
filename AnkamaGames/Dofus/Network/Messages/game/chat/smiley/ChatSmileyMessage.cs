


















// Generated on 01/22/2023 17:42:42
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ChatSmileyMessage : Dofus2Message
{

public const uint Id = 9057;
public override uint MessageId
{
    get { return Id; }
}

public double entityId;
        public uint smileyId;
        public int accountId;
        

public ChatSmileyMessage()
{
}

public ChatSmileyMessage(double entityId, uint smileyId, int accountId)
        {
            this.entityId = entityId;
            this.smileyId = smileyId;
            this.accountId = accountId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(entityId);
            writer.WriteVarShort((int)smileyId);
            writer.WriteInt(accountId);
            

}

public override void Deserialize(IDataReader reader)
{

entityId = reader.ReadDouble();
            smileyId = reader.ReadVarUhShort();
            accountId = reader.ReadInt();
            

}


}


}