


















// Generated on 01/22/2023 17:42:58
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class LivingObjectMessageRequestMessage : Dofus2Message
{

public const uint Id = 5252;
public override uint MessageId
{
    get { return Id; }
}

public uint msgId;
        public string[] parameters;
        public uint livingObject;
        

public LivingObjectMessageRequestMessage()
{
}

public LivingObjectMessageRequestMessage(uint msgId, string[] parameters, uint livingObject)
        {
            this.msgId = msgId;
            this.parameters = parameters;
            this.livingObject = livingObject;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)msgId);
            writer.WriteShort((short)parameters.Length);
            foreach (var entry in parameters)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteVarInt((int)livingObject);
            

}

public override void Deserialize(IDataReader reader)
{

msgId = reader.ReadVarUhShort();
            var limit = (ushort)reader.ReadUShort();
            parameters = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 parameters[i] = reader.ReadUTF();
            }
            livingObject = reader.ReadVarUhInt();
            

}


}


}