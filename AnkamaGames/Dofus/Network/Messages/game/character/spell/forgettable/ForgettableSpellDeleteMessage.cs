


















// Generated on 01/22/2023 17:42:41
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ForgettableSpellDeleteMessage : Dofus2Message
{

public const uint Id = 1206;
public override uint MessageId
{
    get { return Id; }
}

public sbyte reason;
        public int[] spells;
        

public ForgettableSpellDeleteMessage()
{
}

public ForgettableSpellDeleteMessage(sbyte reason, int[] spells)
        {
            this.reason = reason;
            this.spells = spells;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(reason);
            writer.WriteShort((short)spells.Length);
            foreach (var entry in spells)
            {
                 writer.WriteInt(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

reason = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            spells = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 spells[i] = reader.ReadInt();
            }
            

}


}


}