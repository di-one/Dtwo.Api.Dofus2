


















// Generated on 01/22/2023 17:42:48
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class LockableShowCodeDialogMessage : Dofus2Message
{

public const uint Id = 6049;
public override uint MessageId
{
    get { return Id; }
}

public bool changeOrUse;
        public sbyte codeSize;
        

public LockableShowCodeDialogMessage()
{
}

public LockableShowCodeDialogMessage(bool changeOrUse, sbyte codeSize)
        {
            this.changeOrUse = changeOrUse;
            this.codeSize = codeSize;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(changeOrUse);
            writer.WriteSbyte(codeSize);
            

}

public override void Deserialize(IDataReader reader)
{

changeOrUse = reader.ReadBoolean();
            codeSize = reader.ReadSbyte();
            

}


}


}