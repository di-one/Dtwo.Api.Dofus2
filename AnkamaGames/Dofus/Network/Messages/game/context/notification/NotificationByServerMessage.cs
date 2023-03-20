


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class NotificationByServerMessage : Dofus2Message
{

public const uint Id = 2558;
public override uint MessageId
{
    get { return Id; }
}

public uint id;
        public string[] parameters;
        public bool forceOpen;
        

public NotificationByServerMessage()
{
}

public NotificationByServerMessage(uint id, string[] parameters, bool forceOpen)
        {
            this.id = id;
            this.parameters = parameters;
            this.forceOpen = forceOpen;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)id);
            writer.WriteShort((short)parameters.Length);
            foreach (var entry in parameters)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteBoolean(forceOpen);
            

}

public override void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhShort();
            var limit = (ushort)reader.ReadUShort();
            parameters = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 parameters[i] = reader.ReadUTF();
            }
            forceOpen = reader.ReadBoolean();
            

}


}


}