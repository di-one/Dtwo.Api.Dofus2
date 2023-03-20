


















// Generated on 01/22/2023 17:43:02
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HaapiValidationRequestMessage : Dofus2Message
{

public const uint Id = 2106;
public override uint MessageId
{
    get { return Id; }
}

public string transaction;
        

public HaapiValidationRequestMessage()
{
}

public HaapiValidationRequestMessage(string transaction)
        {
            this.transaction = transaction;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(transaction);
            

}

public override void Deserialize(IDataReader reader)
{

transaction = reader.ReadUTF();
            

}


}


}