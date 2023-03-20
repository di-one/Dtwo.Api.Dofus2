


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class ObjectItemInformationWithQuantity : ObjectItemMinimalInformation
{

public const short Id = 3982;
public override short TypeId
{
    get { return Id; }
}

public uint quantity;
        

public ObjectItemInformationWithQuantity()
{
}

public ObjectItemInformationWithQuantity(uint objectGID, Types.ObjectEffect[] effects, uint quantity)
         : base(objectGID, effects)
        {
            this.quantity = quantity;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)quantity);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            quantity = reader.ReadVarUhInt();
            

}


}


}