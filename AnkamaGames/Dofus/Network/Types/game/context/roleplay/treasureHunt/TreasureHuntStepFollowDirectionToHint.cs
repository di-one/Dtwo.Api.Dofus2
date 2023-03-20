


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class TreasureHuntStepFollowDirectionToHint : TreasureHuntStep
{

public const short Id = 4635;
public override short TypeId
{
    get { return Id; }
}

public sbyte direction;
        public uint npcId;
        

public TreasureHuntStepFollowDirectionToHint()
{
}

public TreasureHuntStepFollowDirectionToHint(sbyte direction, uint npcId)
        {
            this.direction = direction;
            this.npcId = npcId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(direction);
            writer.WriteVarShort((int)npcId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            direction = reader.ReadSbyte();
            npcId = reader.ReadVarUhShort();
            

}


}


}