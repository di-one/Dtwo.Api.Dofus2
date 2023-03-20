


















// Generated on 01/22/2023 17:42:39
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AllianceListMessage : Dofus2Message
{

public const uint Id = 1215;
public override uint MessageId
{
    get { return Id; }
}

public Types.AllianceFactSheetInformations[] alliances;
        

public AllianceListMessage()
{
}

public AllianceListMessage(Types.AllianceFactSheetInformations[] alliances)
        {
            this.alliances = alliances;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)alliances.Length);
            foreach (var entry in alliances)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            alliances = new Types.AllianceFactSheetInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 alliances[i] = new Types.AllianceFactSheetInformations();
                 alliances[i].Deserialize(reader);
            }
            

}


}


}