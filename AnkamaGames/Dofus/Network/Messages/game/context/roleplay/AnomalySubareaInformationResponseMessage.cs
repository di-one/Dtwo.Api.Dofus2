


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AnomalySubareaInformationResponseMessage : Dofus2Message
{

public const uint Id = 8160;
public override uint MessageId
{
    get { return Id; }
}

public Types.AnomalySubareaInformation[] subareas;
        

public AnomalySubareaInformationResponseMessage()
{
}

public AnomalySubareaInformationResponseMessage(Types.AnomalySubareaInformation[] subareas)
        {
            this.subareas = subareas;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)subareas.Length);
            foreach (var entry in subareas)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            subareas = new Types.AnomalySubareaInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 subareas[i] = new Types.AnomalySubareaInformation();
                 subareas[i].Deserialize(reader);
            }
            

}


}


}