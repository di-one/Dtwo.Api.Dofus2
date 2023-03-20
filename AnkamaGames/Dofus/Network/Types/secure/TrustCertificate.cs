


















// Generated on 01/22/2023 17:43:08
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class TrustCertificate
{

public const short Id = 429;
public virtual short TypeId
{
    get { return Id; }
}

public int id;
        public string hash;
        

public TrustCertificate()
{
}

public TrustCertificate(int id, string hash)
        {
            this.id = id;
            this.hash = hash;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(id);
            writer.WriteUTF(hash);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadInt();
            hash = reader.ReadUTF();
            

}


}


}