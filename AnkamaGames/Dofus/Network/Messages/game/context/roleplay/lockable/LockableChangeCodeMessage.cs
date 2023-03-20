


















// Generated on 01/22/2023 17:42:48
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class LockableChangeCodeMessage : Dofus2Message
{

public const uint Id = 5435;
public override uint MessageId
{
    get { return Id; }
}

public string code;
        

public LockableChangeCodeMessage()
{
}

public LockableChangeCodeMessage(string code)
        {
            this.code = code;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(code);
            

}

public override void Deserialize(IDataReader reader)
{

code = reader.ReadUTF();
            

}


}


}