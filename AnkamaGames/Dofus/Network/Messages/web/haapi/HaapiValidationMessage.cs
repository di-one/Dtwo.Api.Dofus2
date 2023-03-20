


















// Generated on 01/22/2023 17:43:02
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HaapiValidationMessage : Dofus2Message
{

public const uint Id = 3738;
public override uint MessageId
{
    get { return Id; }
}

public sbyte action;
        public sbyte code;
        

public HaapiValidationMessage()
{
}

public HaapiValidationMessage(sbyte action, sbyte code)
        {
            this.action = action;
            this.code = code;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(action);
            writer.WriteSbyte(code);
            

}

public override void Deserialize(IDataReader reader)
{

action = reader.ReadSbyte();
            code = reader.ReadSbyte();
            

}


}


}