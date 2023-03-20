


















// Generated on 01/22/2023 17:42:44
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class MountRenamedMessage : Dofus2Message
{

public const uint Id = 7843;
public override uint MessageId
{
    get { return Id; }
}

public int mountId;
        public string name;
        

public MountRenamedMessage()
{
}

public MountRenamedMessage(int mountId, string name)
        {
            this.mountId = mountId;
            this.name = name;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)mountId);
            writer.WriteUTF(name);
            

}

public override void Deserialize(IDataReader reader)
{

mountId = reader.ReadVarInt();
            name = reader.ReadUTF();
            

}


}


}