


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class AbstractContactInformations
{

public const short Id = 2855;
public virtual short TypeId
{
    get { return Id; }
}

public int accountId;
        public Types.AccountTagInformation accountTag;
        

public AbstractContactInformations()
{
}

public AbstractContactInformations(int accountId, Types.AccountTagInformation accountTag)
        {
            this.accountId = accountId;
            this.accountTag = accountTag;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(accountId);
            accountTag.Serialize(writer);
            

}

public virtual void Deserialize(IDataReader reader)
{

accountId = reader.ReadInt();
            accountTag = new Types.AccountTagInformation();
            accountTag.Deserialize(reader);
            

}


}


}