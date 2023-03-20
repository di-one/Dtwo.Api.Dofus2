


















// Generated on 01/22/2023 17:42:48
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PaddockToSellListMessage : Dofus2Message
{

public const uint Id = 505;
public override uint MessageId
{
    get { return Id; }
}

public uint pageIndex;
        public uint totalPage;
        public Types.PaddockInformationsForSell[] paddockList;
        

public PaddockToSellListMessage()
{
}

public PaddockToSellListMessage(uint pageIndex, uint totalPage, Types.PaddockInformationsForSell[] paddockList)
        {
            this.pageIndex = pageIndex;
            this.totalPage = totalPage;
            this.paddockList = paddockList;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)pageIndex);
            writer.WriteVarShort((int)totalPage);
            writer.WriteShort((short)paddockList.Length);
            foreach (var entry in paddockList)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

pageIndex = reader.ReadVarUhShort();
            totalPage = reader.ReadVarUhShort();
            var limit = (ushort)reader.ReadUShort();
            paddockList = new Types.PaddockInformationsForSell[limit];
            for (int i = 0; i < limit; i++)
            {
                 paddockList[i] = new Types.PaddockInformationsForSell();
                 paddockList[i].Deserialize(reader);
            }
            

}


}


}