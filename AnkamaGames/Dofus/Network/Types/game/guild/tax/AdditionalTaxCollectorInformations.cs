


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class AdditionalTaxCollectorInformations
{

public const short Id = 5519;
public virtual short TypeId
{
    get { return Id; }
}

public string collectorCallerName;
        public int date;
        

public AdditionalTaxCollectorInformations()
{
}

public AdditionalTaxCollectorInformations(string collectorCallerName, int date)
        {
            this.collectorCallerName = collectorCallerName;
            this.date = date;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteUTF(collectorCallerName);
            writer.WriteInt(date);
            

}

public virtual void Deserialize(IDataReader reader)
{

collectorCallerName = reader.ReadUTF();
            date = reader.ReadInt();
            

}


}


}