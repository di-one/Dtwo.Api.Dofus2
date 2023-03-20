


















// Generated on 01/22/2023 17:43:04
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class BasicAllianceInformations : AbstractSocialGroupInfos
{

public const short Id = 2850;
public override short TypeId
{
    get { return Id; }
}

public uint allianceId;
        public string allianceTag;
        

public BasicAllianceInformations()
{
}

public BasicAllianceInformations(uint allianceId, string allianceTag)
        {
            this.allianceId = allianceId;
            this.allianceTag = allianceTag;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)allianceId);
            writer.WriteUTF(allianceTag);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            allianceId = reader.ReadVarUhInt();
            allianceTag = reader.ReadUTF();
            

}


}


}