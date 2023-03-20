


















// Generated on 01/22/2023 17:43:01
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ContactLookMessage : Dofus2Message
{

public const uint Id = 2519;
public override uint MessageId
{
    get { return Id; }
}

public uint requestId;
        public string playerName;
        public double playerId;
        public Types.EntityLook look;
        

public ContactLookMessage()
{
}

public ContactLookMessage(uint requestId, string playerName, double playerId, Types.EntityLook look)
        {
            this.requestId = requestId;
            this.playerName = playerName;
            this.playerId = playerId;
            this.look = look;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)requestId);
            writer.WriteUTF(playerName);
            writer.WriteVarLong(playerId);
            look.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

requestId = reader.ReadVarUhInt();
            playerName = reader.ReadUTF();
            playerId = reader.ReadVarUhLong();
            look = new Types.EntityLook();
            look.Deserialize(reader);
            

}


}


}