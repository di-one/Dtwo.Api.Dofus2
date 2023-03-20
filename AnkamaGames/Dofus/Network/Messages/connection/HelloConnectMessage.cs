


















// Generated on 01/22/2023 17:42:36
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HelloConnectMessage : Dofus2Message
{

public const uint Id = 5355;
public override uint MessageId
{
    get { return Id; }
}

public string salt;
        public sbyte[] key;
        

public HelloConnectMessage()
{
}

public HelloConnectMessage(string salt, sbyte[] key)
        {
            this.salt = salt;
            this.key = key;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(salt);
            writer.WriteVarInt((int)(ushort)key.Length);
            foreach (var entry in key)
            {
                 writer.WriteSbyte(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

salt = reader.ReadUTF();
            var limit = (ushort)reader.ReadVarInt();
            key = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 key[i] = reader.ReadSbyte();
            }
            

}


}


}