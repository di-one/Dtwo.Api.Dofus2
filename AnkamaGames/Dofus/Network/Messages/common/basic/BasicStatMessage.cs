


















// Generated on 01/22/2023 17:42:36
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BasicStatMessage : Dofus2Message
{

public const uint Id = 1873;
public override uint MessageId
{
    get { return Id; }
}

public double timeSpent;
        public uint statId;
        

public BasicStatMessage()
{
}

public BasicStatMessage(double timeSpent, uint statId)
        {
            this.timeSpent = timeSpent;
            this.statId = statId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(timeSpent);
            writer.WriteVarShort((int)statId);
            

}

public override void Deserialize(IDataReader reader)
{

timeSpent = reader.ReadDouble();
            statId = reader.ReadVarUhShort();
            

}


}


}