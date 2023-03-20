


















// Generated on 01/22/2023 17:42:43
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ShowCellMessage : Dofus2Message
{

public const uint Id = 4902;
public override uint MessageId
{
    get { return Id; }
}

public double sourceId;
        public uint cellId;
        

public ShowCellMessage()
{
}

public ShowCellMessage(double sourceId, uint cellId)
        {
            this.sourceId = sourceId;
            this.cellId = cellId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(sourceId);
            writer.WriteVarShort((int)cellId);
            

}

public override void Deserialize(IDataReader reader)
{

sourceId = reader.ReadDouble();
            cellId = reader.ReadVarUhShort();
            

}


}


}