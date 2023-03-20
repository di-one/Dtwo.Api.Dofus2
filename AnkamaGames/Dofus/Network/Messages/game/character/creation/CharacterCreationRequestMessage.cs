


















// Generated on 01/22/2023 17:42:41
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class CharacterCreationRequestMessage : Dofus2Message
{

public const uint Id = 2768;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        public sbyte breed;
        public bool sex;
        public int[] colors;
        public uint cosmeticId;
        

public CharacterCreationRequestMessage()
{
}

public CharacterCreationRequestMessage(string name, sbyte breed, bool sex, int[] colors, uint cosmeticId)
        {
            this.name = name;
            this.breed = breed;
            this.sex = sex;
            this.colors = colors;
            this.cosmeticId = cosmeticId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(name);
            writer.WriteSbyte(breed);
            writer.WriteBoolean(sex);
            writer.WriteShort((short)colors.Length);
            foreach (var entry in colors)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteVarShort((int)cosmeticId);
            

}

public override void Deserialize(IDataReader reader)
{

name = reader.ReadUTF();
            breed = reader.ReadSbyte();
            sex = reader.ReadBoolean();
            var limit = (ushort)reader.ReadUShort();
            colors = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 colors[i] = reader.ReadInt();
            }
            cosmeticId = reader.ReadVarUhShort();
            

}


}


}