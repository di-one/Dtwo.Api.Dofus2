


















// Generated on 01/22/2023 17:42:36
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class SelectedServerRefusedMessage : Dofus2Message
{

public const uint Id = 2277;
public override uint MessageId
{
    get { return Id; }
}

public uint serverId;
        public sbyte error;
        public sbyte serverStatus;
        

public SelectedServerRefusedMessage()
{
}

public SelectedServerRefusedMessage(uint serverId, sbyte error, sbyte serverStatus)
        {
            this.serverId = serverId;
            this.error = error;
            this.serverStatus = serverStatus;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)serverId);
            writer.WriteSbyte(error);
            writer.WriteSbyte(serverStatus);
            

}

public override void Deserialize(IDataReader reader)
{

serverId = reader.ReadVarUhShort();
            error = reader.ReadSbyte();
            serverStatus = reader.ReadSbyte();
            

}


}


}