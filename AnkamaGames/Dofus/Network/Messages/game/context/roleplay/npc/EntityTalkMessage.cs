


















// Generated on 01/22/2023 17:42:48
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class EntityTalkMessage : Dofus2Message
{

public const uint Id = 5745;
public override uint MessageId
{
    get { return Id; }
}

public double entityId;
        public uint textId;
        public string[] parameters;
        

public EntityTalkMessage()
{
}

public EntityTalkMessage(double entityId, uint textId, string[] parameters)
        {
            this.entityId = entityId;
            this.textId = textId;
            this.parameters = parameters;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(entityId);
            writer.WriteVarShort((int)textId);
            writer.WriteShort((short)parameters.Length);
            foreach (var entry in parameters)
            {
                 writer.WriteUTF(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

entityId = reader.ReadDouble();
            textId = reader.ReadVarUhShort();
            var limit = (ushort)reader.ReadUShort();
            parameters = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 parameters[i] = reader.ReadUTF();
            }
            

}


}


}