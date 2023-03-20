


















// Generated on 01/22/2023 17:43:03
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class ActorExtendedAlignmentInformations : ActorAlignmentInformations
{

public const short Id = 7183;
public override short TypeId
{
    get { return Id; }
}

public uint honor;
        public uint honorGradeFloor;
        public uint honorNextGradeFloor;
        public sbyte aggressable;
        

public ActorExtendedAlignmentInformations()
{
}

public ActorExtendedAlignmentInformations(sbyte alignmentSide, sbyte alignmentValue, sbyte alignmentGrade, double characterPower, uint honor, uint honorGradeFloor, uint honorNextGradeFloor, sbyte aggressable)
         : base(alignmentSide, alignmentValue, alignmentGrade, characterPower)
        {
            this.honor = honor;
            this.honorGradeFloor = honorGradeFloor;
            this.honorNextGradeFloor = honorNextGradeFloor;
            this.aggressable = aggressable;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)honor);
            writer.WriteVarShort((int)honorGradeFloor);
            writer.WriteVarShort((int)honorNextGradeFloor);
            writer.WriteSbyte(aggressable);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            honor = reader.ReadVarUhShort();
            honorGradeFloor = reader.ReadVarUhShort();
            honorNextGradeFloor = reader.ReadVarUhShort();
            aggressable = reader.ReadSbyte();
            

}


}


}