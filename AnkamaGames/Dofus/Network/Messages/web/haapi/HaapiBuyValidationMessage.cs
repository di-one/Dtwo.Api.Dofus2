


















// Generated on 01/22/2023 17:43:02
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HaapiBuyValidationMessage : HaapiValidationMessage
{

public const uint Id = 9166;
public override uint MessageId
{
    get { return Id; }
}

public double amount;
        public string email;
        

public HaapiBuyValidationMessage()
{
}

public HaapiBuyValidationMessage(sbyte action, sbyte code, double amount, string email)
         : base(action, code)
        {
            this.amount = amount;
            this.email = email;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(amount);
            writer.WriteUTF(email);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            amount = reader.ReadVarUhLong();
            email = reader.ReadUTF();
            

}


}


}