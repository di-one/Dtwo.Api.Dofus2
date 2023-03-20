


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class PortalInformation
{

public const short Id = 9720;
public virtual short TypeId
{
    get { return Id; }
}

public int portalId;
        public short areaId;
        

public PortalInformation()
{
}

public PortalInformation(int portalId, short areaId)
        {
            this.portalId = portalId;
            this.areaId = areaId;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(portalId);
            writer.WriteShort(areaId);
            

}

public virtual void Deserialize(IDataReader reader)
{

portalId = reader.ReadInt();
            areaId = reader.ReadShort();
            

}


}


}