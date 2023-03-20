


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HouseToSellListMessage : Dofus2Message
{

public const uint Id = 3218;
public override uint MessageId
{
    get { return Id; }
}

public uint pageIndex;
        public uint totalPage;
        public Types.HouseInformationsForSell[] houseList;
        

public HouseToSellListMessage()
{
}

public HouseToSellListMessage(uint pageIndex, uint totalPage, Types.HouseInformationsForSell[] houseList)
        {
            this.pageIndex = pageIndex;
            this.totalPage = totalPage;
            this.houseList = houseList;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)pageIndex);
            writer.WriteVarShort((int)totalPage);
            writer.WriteShort((short)houseList.Length);
            foreach (var entry in houseList)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

pageIndex = reader.ReadVarUhShort();
            totalPage = reader.ReadVarUhShort();
            var limit = (ushort)reader.ReadUShort();
            houseList = new Types.HouseInformationsForSell[limit];
            for (int i = 0; i < limit; i++)
            {
                 houseList[i] = new Types.HouseInformationsForSell();
                 houseList[i].Deserialize(reader);
            }
            

}


}


}