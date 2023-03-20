


















//// Generated on 01/22/2023 17:42:46
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
//using Dtwo.API.Dofus2.Encoding;
//using Dtwo.API.Dofus2.Network.Messages;

//namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
//{

//public class EmoteListMessage : Dofus2Message
//{

//public const uint Id = 2677;
//public override uint MessageId
//{
//    get { return Id; }
//}

//public Types.uint[] emoteIds;
        

//public EmoteListMessage()
//{
//}

//public EmoteListMessage(Types.uint[] emoteIds)
//        {
//            this.emoteIds = emoteIds;
//        }
        

//public override void Serialize(IDataWriter writer)
//{

//writer.WriteShort((short)emoteIds.Length);
//            foreach (var entry in emoteIds)
//            {
//                 entry.Serialize(writer);
//            }
            

//}

//public override void Deserialize(IDataReader reader)
//{

//var limit = (ushort)reader.ReadUShort();
//            emoteIds = new Types.uint[limit];
//            for (int i = 0; i < limit; i++)
//            {
//                 emoteIds[i] = new Types.uint();
//                 emoteIds[i].Deserialize(reader);
//            }
            

//}


//}


//}