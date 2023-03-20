


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class IdolListMessage : Dofus2Message
{

public const uint Id = 5456;
public override uint MessageId
{
    get { return Id; }
}

public uint[] chosenIdols;
        public uint[] partyChosenIdols;
        public Types.PartyIdol[] partyIdols;
        

public IdolListMessage()
{
}

public IdolListMessage(uint[] chosenIdols, uint[] partyChosenIdols, Types.PartyIdol[] partyIdols)
        {
            this.chosenIdols = chosenIdols;
            this.partyChosenIdols = partyChosenIdols;
            this.partyIdols = partyIdols;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)chosenIdols.Length);
            foreach (var entry in chosenIdols)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)partyChosenIdols.Length);
            foreach (var entry in partyChosenIdols)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)partyIdols.Length);
            foreach (var entry in partyIdols)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            chosenIdols = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 chosenIdols[i] = reader.ReadVarUhShort();
            }
            limit = (ushort)reader.ReadUShort();
            partyChosenIdols = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 partyChosenIdols[i] = reader.ReadVarUhShort();
            }
            limit = (ushort)reader.ReadUShort();
            partyIdols = new Types.PartyIdol[limit];
            for (int i = 0; i < limit; i++)
            {
                 partyIdols[i] = ProtocolTypeManager.GetInstance<Types.PartyIdol>(reader.ReadUShort());
                 partyIdols[i].Deserialize(reader);
            }
            

}


}


}