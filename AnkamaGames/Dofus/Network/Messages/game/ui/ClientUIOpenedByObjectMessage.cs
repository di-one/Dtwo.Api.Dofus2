


















// Generated on 01/22/2023 17:43:01
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ClientUIOpenedByObjectMessage : ClientUIOpenedMessage
{

public const uint Id = 3176;
public override uint MessageId
{
    get { return Id; }
}

public uint uid;
        

public ClientUIOpenedByObjectMessage()
{
}

public ClientUIOpenedByObjectMessage(sbyte type, uint uid)
         : base(type)
        {
            this.uid = uid;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)uid);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            uid = reader.ReadVarUhInt();
            

}


}


}