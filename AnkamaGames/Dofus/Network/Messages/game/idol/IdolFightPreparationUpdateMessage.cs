


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class IdolFightPreparationUpdateMessage : Dofus2Message
{

public const uint Id = 9059;
public override uint MessageId
{
    get { return Id; }
}

public sbyte idolSource;
        public Types.Idol[] idols;
        

public IdolFightPreparationUpdateMessage()
{
}

public IdolFightPreparationUpdateMessage(sbyte idolSource, Types.Idol[] idols)
        {
            this.idolSource = idolSource;
            this.idols = idols;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(idolSource);
            writer.WriteShort((short)idols.Length);
            foreach (var entry in idols)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

idolSource = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            idols = new Types.Idol[limit];
            for (int i = 0; i < limit; i++)
            {
                 idols[i] = ProtocolTypeManager.GetInstance<Types.Idol>(reader.ReadUShort());
                 idols[i].Deserialize(reader);
            }
            

}


}


}