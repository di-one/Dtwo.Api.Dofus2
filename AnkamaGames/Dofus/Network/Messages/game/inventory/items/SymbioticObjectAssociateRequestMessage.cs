


















// Generated on 01/22/2023 17:42:59
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class SymbioticObjectAssociateRequestMessage : Dofus2Message
{

public const uint Id = 8550;
public override uint MessageId
{
    get { return Id; }
}

public uint symbioteUID;
        public byte symbiotePos;
        public uint hostUID;
        public byte hostPos;
        

public SymbioticObjectAssociateRequestMessage()
{
}

public SymbioticObjectAssociateRequestMessage(uint symbioteUID, byte symbiotePos, uint hostUID, byte hostPos)
        {
            this.symbioteUID = symbioteUID;
            this.symbiotePos = symbiotePos;
            this.hostUID = hostUID;
            this.hostPos = hostPos;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)symbioteUID);
            writer.WriteByte(symbiotePos);
            writer.WriteVarInt((int)hostUID);
            writer.WriteByte(hostPos);
            

}

public override void Deserialize(IDataReader reader)
{

symbioteUID = reader.ReadVarUhInt();
            symbiotePos = reader.ReadByte();
            hostUID = reader.ReadVarUhInt();
            hostPos = reader.ReadByte();
            

}


}


}