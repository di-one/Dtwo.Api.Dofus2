


















// Generated on 01/22/2023 17:43:05
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class HumanOptionTitle : HumanOption
{

public const short Id = 8686;
public override short TypeId
{
    get { return Id; }
}

public uint titleId;
        public string titleParam;
        

public HumanOptionTitle()
{
}

public HumanOptionTitle(uint titleId, string titleParam)
        {
            this.titleId = titleId;
            this.titleParam = titleParam;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)titleId);
            writer.WriteUTF(titleParam);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            titleId = reader.ReadVarUhShort();
            titleParam = reader.ReadUTF();
            

}


}


}