


















// Generated on 01/22/2023 17:42:42
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class MoodSmileyResultMessage : Dofus2Message
{

public const uint Id = 8828;
public override uint MessageId
{
    get { return Id; }
}

public sbyte resultCode;
        public uint smileyId;
        

public MoodSmileyResultMessage()
{
}

public MoodSmileyResultMessage(sbyte resultCode, uint smileyId)
        {
            this.resultCode = resultCode;
            this.smileyId = smileyId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(resultCode);
            writer.WriteVarShort((int)smileyId);
            

}

public override void Deserialize(IDataReader reader)
{

resultCode = reader.ReadSbyte();
            smileyId = reader.ReadVarUhShort();
            

}


}


}