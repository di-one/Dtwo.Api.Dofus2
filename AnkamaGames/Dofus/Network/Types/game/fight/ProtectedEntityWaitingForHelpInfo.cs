


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class ProtectedEntityWaitingForHelpInfo
{

public const short Id = 9095;
public virtual short TypeId
{
    get { return Id; }
}

public int timeLeftBeforeFight;
        public int waitTimeForPlacement;
        public sbyte nbPositionForDefensors;
        

public ProtectedEntityWaitingForHelpInfo()
{
}

public ProtectedEntityWaitingForHelpInfo(int timeLeftBeforeFight, int waitTimeForPlacement, sbyte nbPositionForDefensors)
        {
            this.timeLeftBeforeFight = timeLeftBeforeFight;
            this.waitTimeForPlacement = waitTimeForPlacement;
            this.nbPositionForDefensors = nbPositionForDefensors;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(timeLeftBeforeFight);
            writer.WriteInt(waitTimeForPlacement);
            writer.WriteSbyte(nbPositionForDefensors);
            

}

public virtual void Deserialize(IDataReader reader)
{

timeLeftBeforeFight = reader.ReadInt();
            waitTimeForPlacement = reader.ReadInt();
            nbPositionForDefensors = reader.ReadSbyte();
            

}


}


}