


















// Generated on 01/22/2023 17:42:48
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class NpcDialogQuestionMessage : Dofus2Message
{

public const uint Id = 5287;
public override uint MessageId
{
    get { return Id; }
}

public uint messageId;
        public string[] dialogParams;
        public uint[] visibleReplies;
        

public NpcDialogQuestionMessage()
{
}

public NpcDialogQuestionMessage(uint messageId, string[] dialogParams, uint[] visibleReplies)
        {
            this.messageId = messageId;
            this.dialogParams = dialogParams;
            this.visibleReplies = visibleReplies;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)messageId);
            writer.WriteShort((short)dialogParams.Length);
            foreach (var entry in dialogParams)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteShort((short)visibleReplies.Length);
            foreach (var entry in visibleReplies)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

messageId = reader.ReadVarUhInt();
            var limit = (ushort)reader.ReadUShort();
            dialogParams = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 dialogParams[i] = reader.ReadUTF();
            }
            limit = (ushort)reader.ReadUShort();
            visibleReplies = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 visibleReplies[i] = reader.ReadVarUhInt();
            }
            

}


}


}