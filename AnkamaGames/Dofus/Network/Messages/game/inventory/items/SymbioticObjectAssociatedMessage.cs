


















// Generated on 01/22/2023 17:42:59
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class SymbioticObjectAssociatedMessage : Dofus2Message
{

public const uint Id = 287;
public override uint MessageId
{
    get { return Id; }
}

public uint hostUID;
        

public SymbioticObjectAssociatedMessage()
{
}

public SymbioticObjectAssociatedMessage(uint hostUID)
        {
            this.hostUID = hostUID;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)hostUID);
            

}

public override void Deserialize(IDataReader reader)
{

hostUID = reader.ReadVarUhInt();
            

}


}


}