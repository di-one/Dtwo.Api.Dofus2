


















//// Generated on 01/22/2023 17:43:00
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
//using Dtwo.API.Dofus2.Encoding;
//using Dtwo.API.Dofus2.Network.Messages;

//namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
//{

//public class ActivityLockRequestMessage : Dofus2Message
//{

//public const uint Id = 3730;
//public override uint MessageId
//{
//    get { return Id; }
//}

//public uint activityId;
//        public bool lock;
        

//public ActivityLockRequestMessage()
//{
//}

//public ActivityLockRequestMessage(uint activityId, bool lock)
//        {
//            this.activityId = activityId;
//            this.lock = lock;
//        }
        

//public override void Serialize(IDataWriter writer)
//{

//writer.WriteVarShort((int)activityId);
//            writer.WriteBoolean(lock);
            

//}

//public override void Deserialize(IDataReader reader)
//{

//activityId = reader.ReadVarUhShort();
//            lock = reader.ReadBoolean();
            

//}


//}


//}