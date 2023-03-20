


















// Generated on 01/04/2023 15:29:32
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ObjectUseMessage : Dofus2Message
{

public const uint Id = 4717;
public override uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        

public ObjectUseMessage()
{
}

public ObjectUseMessage(uint objectUID)
        {
            this.objectUID = objectUID;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectUID);
            

}

public override void Deserialize(IDataReader reader)
{

objectUID = reader.ReadVarUhInt();
            

}


}


}