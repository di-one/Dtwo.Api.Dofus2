


















// Generated on 01/22/2023 17:42:40
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ServerSessionConstantsMessage : Dofus2Message
{

public const uint Id = 8962;
public override uint MessageId
{
    get { return Id; }
}

public Types.ServerSessionConstant[] variables;
        

public ServerSessionConstantsMessage()
{
}

public ServerSessionConstantsMessage(Types.ServerSessionConstant[] variables)
        {
            this.variables = variables;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)variables.Length);
            foreach (var entry in variables)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            variables = new Types.ServerSessionConstant[limit];
            for (int i = 0; i < limit; i++)
            {
                 variables[i] = ProtocolTypeManager.GetInstance<Types.ServerSessionConstant>(reader.ReadUShort());
                 variables[i].Deserialize(reader);
            }
            

}


}


}