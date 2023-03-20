


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class DocumentReadingBeginMessage : Dofus2Message
{

public const uint Id = 5660;
public override uint MessageId
{
    get { return Id; }
}

public uint documentId;
        

public DocumentReadingBeginMessage()
{
}

public DocumentReadingBeginMessage(uint documentId)
        {
            this.documentId = documentId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)documentId);
            

}

public override void Deserialize(IDataReader reader)
{

documentId = reader.ReadVarUhShort();
            

}


}


}