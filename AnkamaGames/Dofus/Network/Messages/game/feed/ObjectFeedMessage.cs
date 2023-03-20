


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ObjectFeedMessage : Dofus2Message
{

public const uint Id = 7649;
public override uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        public Types.ObjectItemQuantity[] meal;
        

public ObjectFeedMessage()
{
}

public ObjectFeedMessage(uint objectUID, Types.ObjectItemQuantity[] meal)
        {
            this.objectUID = objectUID;
            this.meal = meal;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectUID);
            writer.WriteShort((short)meal.Length);
            foreach (var entry in meal)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

objectUID = reader.ReadVarUhInt();
            var limit = (ushort)reader.ReadUShort();
            meal = new Types.ObjectItemQuantity[limit];
            for (int i = 0; i < limit; i++)
            {
                 meal[i] = new Types.ObjectItemQuantity();
                 meal[i].Deserialize(reader);
            }
            

}


}


}