


















// Generated on 01/22/2023 17:42:50
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PartyNameSetErrorMessage : AbstractPartyMessage
{

public const uint Id = 6589;
public override uint MessageId
{
    get { return Id; }
}

public sbyte result;
        

public PartyNameSetErrorMessage()
{
}

public PartyNameSetErrorMessage(uint partyId, sbyte result)
         : base(partyId)
        {
            this.result = result;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(result);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            result = reader.ReadSbyte();
            

}


}


}