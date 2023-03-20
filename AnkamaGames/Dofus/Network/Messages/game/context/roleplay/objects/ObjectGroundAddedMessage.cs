


















// Generated on 01/22/2023 17:42:48
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ObjectGroundAddedMessage : Dofus2Message
{

public const uint Id = 6422;
public override uint MessageId
{
    get { return Id; }
}

public uint cellId;
        public uint objectGID;
        

public ObjectGroundAddedMessage()
{
}

public ObjectGroundAddedMessage(uint cellId, uint objectGID)
        {
            this.cellId = cellId;
            this.objectGID = objectGID;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)cellId);
            writer.WriteVarInt((int)objectGID);
            

}

public override void Deserialize(IDataReader reader)
{

cellId = reader.ReadVarUhShort();
            objectGID = reader.ReadVarUhInt();
            

}


}


}