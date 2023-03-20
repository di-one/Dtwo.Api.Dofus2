


















// Generated on 01/22/2023 17:43:03
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class CharacterCharacteristic
{

public const short Id = 3999;
public virtual short TypeId
{
    get { return Id; }
}

public short characteristicId;
        

public CharacterCharacteristic()
{
}

public CharacterCharacteristic(short characteristicId)
        {
            this.characteristicId = characteristicId;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteShort(characteristicId);
            

}

public virtual void Deserialize(IDataReader reader)
{

characteristicId = reader.ReadShort();
            

}


}


}