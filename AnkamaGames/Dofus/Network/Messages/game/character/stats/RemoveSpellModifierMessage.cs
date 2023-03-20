


















// Generated on 01/22/2023 17:42:41
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class RemoveSpellModifierMessage : Dofus2Message
{

public const uint Id = 2668;
public override uint MessageId
{
    get { return Id; }
}

public double actorId;
        public sbyte modificationType;
        public uint spellId;
        

public RemoveSpellModifierMessage()
{
}

public RemoveSpellModifierMessage(double actorId, sbyte modificationType, uint spellId)
        {
            this.actorId = actorId;
            this.modificationType = modificationType;
            this.spellId = spellId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(actorId);
            writer.WriteSbyte(modificationType);
            writer.WriteVarShort((int)spellId);
            

}

public override void Deserialize(IDataReader reader)
{

actorId = reader.ReadDouble();
            modificationType = reader.ReadSbyte();
            spellId = reader.ReadVarUhShort();
            

}


}


}