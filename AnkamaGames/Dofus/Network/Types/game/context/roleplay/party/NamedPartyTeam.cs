


















// Generated on 01/04/2023 15:29:39
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class NamedPartyTeam
{

public const short Id = 1488;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte teamId;
        public string partyName;
        

public NamedPartyTeam()
{
}

public NamedPartyTeam(sbyte teamId, string partyName)
        {
            this.teamId = teamId;
            this.partyName = partyName;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(teamId);
            writer.WriteUTF(partyName);
            

}

public virtual void Deserialize(IDataReader reader)
{

teamId = reader.ReadSbyte();
            partyName = reader.ReadUTF();
            

}


}


}