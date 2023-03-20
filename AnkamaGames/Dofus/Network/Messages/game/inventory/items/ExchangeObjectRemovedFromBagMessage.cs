


















// Generated on 01/22/2023 17:42:58
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeObjectRemovedFromBagMessage : ExchangeObjectMessage
{

public const uint Id = 2524;
public override uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        

public ExchangeObjectRemovedFromBagMessage()
{
}

public ExchangeObjectRemovedFromBagMessage(bool remote, uint objectUID)
         : base(remote)
        {
            this.objectUID = objectUID;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)objectUID);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            objectUID = reader.ReadVarUhInt();
            

}


}


}