


















// Generated on 01/22/2023 17:42:40
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ServerOptionalFeaturesMessage : Dofus2Message
{

public const uint Id = 2590;
public override uint MessageId
{
    get { return Id; }
}

public int[] features;
        

public ServerOptionalFeaturesMessage()
{
}

public ServerOptionalFeaturesMessage(int[] features)
        {
            this.features = features;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)features.Length);
            foreach (var entry in features)
            {
                 writer.WriteInt(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            features = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 features[i] = reader.ReadInt();
            }
            

}


}


}