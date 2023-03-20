


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AccountHouseMessage : Dofus2Message
{

public const uint Id = 2202;
public override uint MessageId
{
    get { return Id; }
}

public Types.AccountHouseInformations[] houses;
        

public AccountHouseMessage()
{
}

public AccountHouseMessage(Types.AccountHouseInformations[] houses)
        {
            this.houses = houses;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)houses.Length);
            foreach (var entry in houses)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            houses = new Types.AccountHouseInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 houses[i] = new Types.AccountHouseInformations();
                 houses[i].Deserialize(reader);
            }
            

}


}


}