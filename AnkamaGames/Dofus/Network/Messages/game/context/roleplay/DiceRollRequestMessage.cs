


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class DiceRollRequestMessage : Dofus2Message
{

public const uint Id = 1047;
public override uint MessageId
{
    get { return Id; }
}

public uint dice;
        public uint faces;
        public sbyte channel;
        

public DiceRollRequestMessage()
{
}

public DiceRollRequestMessage(uint dice, uint faces, sbyte channel)
        {
            this.dice = dice;
            this.faces = faces;
            this.channel = channel;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)dice);
            writer.WriteVarInt((int)faces);
            writer.WriteSbyte(channel);
            

}

public override void Deserialize(IDataReader reader)
{

dice = reader.ReadVarUhInt();
            faces = reader.ReadVarUhInt();
            channel = reader.ReadSbyte();
            

}


}


}