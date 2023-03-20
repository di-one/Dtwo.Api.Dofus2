


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PrismsListRegisterMessage : Dofus2Message
{

public const uint Id = 2829;
public override uint MessageId
{
    get { return Id; }
}

public sbyte listen;
        

public PrismsListRegisterMessage()
{
}

public PrismsListRegisterMessage(sbyte listen)
        {
            this.listen = listen;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(listen);
            

}

public override void Deserialize(IDataReader reader)
{

listen = reader.ReadSbyte();
            

}


}


}