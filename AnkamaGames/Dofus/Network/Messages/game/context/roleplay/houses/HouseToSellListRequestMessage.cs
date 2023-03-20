


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HouseToSellListRequestMessage : Dofus2Message
{

public const uint Id = 2840;
public override uint MessageId
{
    get { return Id; }
}

public uint pageIndex;
        

public HouseToSellListRequestMessage()
{
}

public HouseToSellListRequestMessage(uint pageIndex)
        {
            this.pageIndex = pageIndex;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)pageIndex);
            

}

public override void Deserialize(IDataReader reader)
{

pageIndex = reader.ReadVarUhShort();
            

}


}


}