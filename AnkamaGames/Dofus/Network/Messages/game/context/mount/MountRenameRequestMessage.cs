


















// Generated on 01/22/2023 17:42:44
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class MountRenameRequestMessage : Dofus2Message
{

public const uint Id = 6285;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        public int mountId;
        

public MountRenameRequestMessage()
{
}

public MountRenameRequestMessage(string name, int mountId)
        {
            this.name = name;
            this.mountId = mountId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(name);
            writer.WriteVarInt((int)mountId);
            

}

public override void Deserialize(IDataReader reader)
{

name = reader.ReadUTF();
            mountId = reader.ReadVarInt();
            

}


}


}