


















// Generated on 01/22/2023 17:42:59
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class WrapperObjectDissociateRequestMessage : Dofus2Message
{

public const uint Id = 4744;
public override uint MessageId
{
    get { return Id; }
}

public uint hostUID;
        public byte hostPos;
        

public WrapperObjectDissociateRequestMessage()
{
}

public WrapperObjectDissociateRequestMessage(uint hostUID, byte hostPos)
        {
            this.hostUID = hostUID;
            this.hostPos = hostPos;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)hostUID);
            writer.WriteByte(hostPos);
            

}

public override void Deserialize(IDataReader reader)
{

hostUID = reader.ReadVarUhInt();
            hostPos = reader.ReadByte();
            

}


}


}