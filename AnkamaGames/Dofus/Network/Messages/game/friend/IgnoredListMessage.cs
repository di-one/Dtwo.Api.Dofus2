


















// Generated on 01/22/2023 17:42:52
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class IgnoredListMessage : Dofus2Message
{

public const uint Id = 2212;
public override uint MessageId
{
    get { return Id; }
}

public Types.IgnoredInformations[] ignoredList;
        

public IgnoredListMessage()
{
}

public IgnoredListMessage(Types.IgnoredInformations[] ignoredList)
        {
            this.ignoredList = ignoredList;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)ignoredList.Length);
            foreach (var entry in ignoredList)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            ignoredList = new Types.IgnoredInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 ignoredList[i] = ProtocolTypeManager.GetInstance<Types.IgnoredInformations>(reader.ReadUShort());
                 ignoredList[i].Deserialize(reader);
            }
            

}


}


}