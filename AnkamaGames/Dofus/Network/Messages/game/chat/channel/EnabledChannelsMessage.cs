


















// Generated on 01/22/2023 17:42:42
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class EnabledChannelsMessage : Dofus2Message
{

public const uint Id = 9386;
public override uint MessageId
{
    get { return Id; }
}

public sbyte[] channels;
        public sbyte[] disallowed;
        

public EnabledChannelsMessage()
{
}

public EnabledChannelsMessage(sbyte[] channels, sbyte[] disallowed)
        {
            this.channels = channels;
            this.disallowed = disallowed;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)(ushort)channels.Length);
            foreach (var entry in channels)
            {
                 writer.WriteSbyte(entry);
            }
            writer.WriteVarInt((int)(ushort)disallowed.Length);
            foreach (var entry in disallowed)
            {
                 writer.WriteSbyte(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadVarInt();
            channels = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 channels[i] = reader.ReadSbyte();
            }
            limit = (ushort)reader.ReadVarInt();
            disallowed = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 disallowed[i] = reader.ReadSbyte();
            }
            

}


}


}