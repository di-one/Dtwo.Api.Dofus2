


















// Generated on 01/22/2023 17:42:41
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class CharacterCreationResultMessage : Dofus2Message
{

public const uint Id = 9042;
public override uint MessageId
{
    get { return Id; }
}

public sbyte result;
        public sbyte reason;
        

public CharacterCreationResultMessage()
{
}

public CharacterCreationResultMessage(sbyte result, sbyte reason)
        {
            this.result = result;
            this.reason = reason;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(result);
            writer.WriteSbyte(reason);
            

}

public override void Deserialize(IDataReader reader)
{

result = reader.ReadSbyte();
            reason = reader.ReadSbyte();
            

}


}


}