


















// Generated on 01/22/2023 17:43:03
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class CharacterHardcoreOrEpicInformations : CharacterBaseInformations
{

public const short Id = 5965;
public override short TypeId
{
    get { return Id; }
}

public sbyte deathState;
        public uint deathCount;
        public uint deathMaxLevel;
        

public CharacterHardcoreOrEpicInformations()
{
}

public CharacterHardcoreOrEpicInformations(double id, string name, uint level, Types.EntityLook entityLook, sbyte breed, bool sex, sbyte deathState, uint deathCount, uint deathMaxLevel)
         : base(id, name, level, entityLook, breed, sex)
        {
            this.deathState = deathState;
            this.deathCount = deathCount;
            this.deathMaxLevel = deathMaxLevel;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(deathState);
            writer.WriteVarShort((int)deathCount);
            writer.WriteVarShort((int)deathMaxLevel);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            deathState = reader.ReadSbyte();
            deathCount = reader.ReadVarUhShort();
            deathMaxLevel = reader.ReadVarUhShort();
            

}


}


}