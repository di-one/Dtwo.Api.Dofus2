


















// Generated on 01/22/2023 17:42:48
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameDataPlayFarmObjectAnimationMessage : Dofus2Message
{

public const uint Id = 7321;
public override uint MessageId
{
    get { return Id; }
}

public uint[] cellId;
        

public GameDataPlayFarmObjectAnimationMessage()
{
}

public GameDataPlayFarmObjectAnimationMessage(uint[] cellId)
        {
            this.cellId = cellId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)cellId.Length);
            foreach (var entry in cellId)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            cellId = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 cellId[i] = reader.ReadVarUhShort();
            }
            

}


}


}