


















// Generated on 01/22/2023 17:43:04
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GameFightFighterTaxCollectorLightInformations : GameFightFighterLightInformations
{

public const short Id = 3187;
public override short TypeId
{
    get { return Id; }
}

public uint firstNameId;
        public uint lastNameId;
        

public GameFightFighterTaxCollectorLightInformations()
{
}

public GameFightFighterTaxCollectorLightInformations(bool sex, bool alive, double id, sbyte wave, uint level, sbyte breed, uint firstNameId, uint lastNameId)
         : base(sex, alive, id, wave, level, breed)
        {
            this.firstNameId = firstNameId;
            this.lastNameId = lastNameId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)firstNameId);
            writer.WriteVarShort((int)lastNameId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            firstNameId = reader.ReadVarUhShort();
            lastNameId = reader.ReadVarUhShort();
            

}


}


}