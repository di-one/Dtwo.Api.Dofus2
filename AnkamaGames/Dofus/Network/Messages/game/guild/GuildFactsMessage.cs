


















// Generated on 01/22/2023 17:42:52
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildFactsMessage : Dofus2Message
{

public const uint Id = 1819;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildFactSheetInformations infos;
        public int creationDate;
        public uint nbTaxCollectors;
        public Types.CharacterMinimalGuildPublicInformations[] members;
        

public GuildFactsMessage()
{
}

public GuildFactsMessage(Types.GuildFactSheetInformations infos, int creationDate, uint nbTaxCollectors, Types.CharacterMinimalGuildPublicInformations[] members)
        {
            this.infos = infos;
            this.creationDate = creationDate;
            this.nbTaxCollectors = nbTaxCollectors;
            this.members = members;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(infos.TypeId);
            infos.Serialize(writer);
            writer.WriteInt(creationDate);
            writer.WriteVarShort((int)nbTaxCollectors);
            writer.WriteShort((short)members.Length);
            foreach (var entry in members)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

infos = ProtocolTypeManager.GetInstance<Types.GuildFactSheetInformations>(reader.ReadUShort());
            infos.Deserialize(reader);
            creationDate = reader.ReadInt();
            nbTaxCollectors = reader.ReadVarUhShort();
            var limit = (ushort)reader.ReadUShort();
            members = new Types.CharacterMinimalGuildPublicInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 members[i] = new Types.CharacterMinimalGuildPublicInformations();
                 members[i].Deserialize(reader);
            }
            

}


}


}