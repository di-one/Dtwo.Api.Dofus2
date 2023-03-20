


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class TreasureHuntShowLegendaryUIMessage : Dofus2Message
{

public const uint Id = 2659;
public override uint MessageId
{
    get { return Id; }
}

public uint[] availableLegendaryIds;
        

public TreasureHuntShowLegendaryUIMessage()
{
}

public TreasureHuntShowLegendaryUIMessage(uint[] availableLegendaryIds)
        {
            this.availableLegendaryIds = availableLegendaryIds;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)availableLegendaryIds.Length);
            foreach (var entry in availableLegendaryIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            availableLegendaryIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 availableLegendaryIds[i] = reader.ReadVarUhShort();
            }
            

}


}


}