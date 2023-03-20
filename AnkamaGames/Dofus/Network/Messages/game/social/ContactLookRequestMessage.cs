


















// Generated on 01/22/2023 17:43:01
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ContactLookRequestMessage : Dofus2Message
{

public const uint Id = 2275;
public override uint MessageId
{
    get { return Id; }
}

public byte requestId;
        public sbyte contactType;
        

public ContactLookRequestMessage()
{
}

public ContactLookRequestMessage(byte requestId, sbyte contactType)
        {
            this.requestId = requestId;
            this.contactType = contactType;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteByte(requestId);
            writer.WriteSbyte(contactType);
            

}

public override void Deserialize(IDataReader reader)
{

requestId = reader.ReadByte();
            contactType = reader.ReadSbyte();
            

}


}


}