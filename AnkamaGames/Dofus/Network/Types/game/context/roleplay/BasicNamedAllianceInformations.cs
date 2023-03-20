


















// Generated on 01/22/2023 17:43:04
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class BasicNamedAllianceInformations : BasicAllianceInformations
{

public const short Id = 1895;
public override short TypeId
{
    get { return Id; }
}

public string allianceName;
        

public BasicNamedAllianceInformations()
{
}

public BasicNamedAllianceInformations(uint allianceId, string allianceTag, string allianceName)
         : base(allianceId, allianceTag)
        {
            this.allianceName = allianceName;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(allianceName);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            allianceName = reader.ReadUTF();
            

}


}


}