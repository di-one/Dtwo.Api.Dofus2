


















// Generated on 01/22/2023 17:42:52
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class CreateGuildRankRequestMessage : Dofus2Message
{

public const uint Id = 5961;
public override uint MessageId
{
    get { return Id; }
}

public uint parentRankId;
        public uint gfxId;
        public string name;
        

public CreateGuildRankRequestMessage()
{
}

public CreateGuildRankRequestMessage(uint parentRankId, uint gfxId, string name)
        {
            this.parentRankId = parentRankId;
            this.gfxId = gfxId;
            this.name = name;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)parentRankId);
            writer.WriteVarInt((int)gfxId);
            writer.WriteUTF(name);
            

}

public override void Deserialize(IDataReader reader)
{

parentRankId = reader.ReadVarUhInt();
            gfxId = reader.ReadVarUhInt();
            name = reader.ReadUTF();
            

}


}


}