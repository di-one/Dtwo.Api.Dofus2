


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class TreasureHuntStepFollowDirectionToPOI : TreasureHuntStep
{

public const short Id = 5302;
public override short TypeId
{
    get { return Id; }
}

public sbyte direction;
        public uint poiLabelId;
        

public TreasureHuntStepFollowDirectionToPOI()
{
}

public TreasureHuntStepFollowDirectionToPOI(sbyte direction, uint poiLabelId)
        {
            this.direction = direction;
            this.poiLabelId = poiLabelId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(direction);
            writer.WriteVarShort((int)poiLabelId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            direction = reader.ReadSbyte();
            poiLabelId = reader.ReadVarUhShort();
            

}


}


}