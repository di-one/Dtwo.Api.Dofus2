


















// Generated on 01/22/2023 17:43:03
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class CharacterToRemodelInformations : CharacterRemodelingInformation
{

public const short Id = 6791;
public override short TypeId
{
    get { return Id; }
}

public sbyte possibleChangeMask;
        public sbyte mandatoryChangeMask;
        

public CharacterToRemodelInformations()
{
}

public CharacterToRemodelInformations(double id, string name, sbyte breed, bool sex, uint cosmeticId, int[] colors, sbyte possibleChangeMask, sbyte mandatoryChangeMask)
         : base(id, name, breed, sex, cosmeticId, colors)
        {
            this.possibleChangeMask = possibleChangeMask;
            this.mandatoryChangeMask = mandatoryChangeMask;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(possibleChangeMask);
            writer.WriteSbyte(mandatoryChangeMask);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            possibleChangeMask = reader.ReadSbyte();
            mandatoryChangeMask = reader.ReadSbyte();
            

}


}


}