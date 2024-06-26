


















// Generated on 01/22/2023 17:43:05
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class JobExperience
{

public const short Id = 4639;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte jobId;
        public byte jobLevel;
        public double jobXP;
        public double jobXpLevelFloor;
        public double jobXpNextLevelFloor;
        

public JobExperience()
{
}

public JobExperience(sbyte jobId, byte jobLevel, double jobXP, double jobXpLevelFloor, double jobXpNextLevelFloor)
        {
            this.jobId = jobId;
            this.jobLevel = jobLevel;
            this.jobXP = jobXP;
            this.jobXpLevelFloor = jobXpLevelFloor;
            this.jobXpNextLevelFloor = jobXpNextLevelFloor;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(jobId);
            writer.WriteByte(jobLevel);
            writer.WriteVarLong(jobXP);
            writer.WriteVarLong(jobXpLevelFloor);
            writer.WriteVarLong(jobXpNextLevelFloor);
            

}

public virtual void Deserialize(IDataReader reader)
{

jobId = reader.ReadSbyte();
            jobLevel = reader.ReadByte();
            jobXP = reader.ReadVarUhLong();
            jobXpLevelFloor = reader.ReadVarUhLong();
            jobXpNextLevelFloor = reader.ReadVarUhLong();
            

}


}


}