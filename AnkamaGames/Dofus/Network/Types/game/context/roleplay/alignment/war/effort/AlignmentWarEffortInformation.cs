


















// Generated on 01/22/2023 17:43:05
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class AlignmentWarEffortInformation
{

public const short Id = 9859;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte alignmentSide;
        public double alignmentWarEffort;
        

public AlignmentWarEffortInformation()
{
}

public AlignmentWarEffortInformation(sbyte alignmentSide, double alignmentWarEffort)
        {
            this.alignmentSide = alignmentSide;
            this.alignmentWarEffort = alignmentWarEffort;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(alignmentSide);
            writer.WriteVarLong(alignmentWarEffort);
            

}

public virtual void Deserialize(IDataReader reader)
{

alignmentSide = reader.ReadSbyte();
            alignmentWarEffort = reader.ReadVarUhLong();
            

}


}


}