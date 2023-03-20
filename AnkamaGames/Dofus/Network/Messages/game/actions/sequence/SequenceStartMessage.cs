


















// Generated on 01/22/2023 17:42:39
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class SequenceStartMessage : Dofus2Message
{

public const uint Id = 4935;
public override uint MessageId
{
    get { return Id; }
}

public sbyte sequenceType;
        public double authorId;
        

public SequenceStartMessage()
{
}

public SequenceStartMessage(sbyte sequenceType, double authorId)
        {
            this.sequenceType = sequenceType;
            this.authorId = authorId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(sequenceType);
            writer.WriteDouble(authorId);
            

}

public override void Deserialize(IDataReader reader)
{

sequenceType = reader.ReadSbyte();
            authorId = reader.ReadDouble();
            

}


}


}