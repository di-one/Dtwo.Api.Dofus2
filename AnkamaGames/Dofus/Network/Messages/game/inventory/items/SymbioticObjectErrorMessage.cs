


















// Generated on 01/22/2023 17:42:59
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class SymbioticObjectErrorMessage : ObjectErrorMessage
{

public const uint Id = 827;
public override uint MessageId
{
    get { return Id; }
}

public sbyte errorCode;
        

public SymbioticObjectErrorMessage()
{
}

public SymbioticObjectErrorMessage(sbyte reason, sbyte errorCode)
         : base(reason)
        {
            this.errorCode = errorCode;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(errorCode);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            errorCode = reader.ReadSbyte();
            

}


}


}