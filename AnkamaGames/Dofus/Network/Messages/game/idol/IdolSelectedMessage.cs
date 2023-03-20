


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class IdolSelectedMessage : Dofus2Message
{

public const uint Id = 9188;
public override uint MessageId
{
    get { return Id; }
}

public bool activate;
        public bool party;
        public uint idolId;
        

public IdolSelectedMessage()
{
}

public IdolSelectedMessage(bool activate, bool party, uint idolId)
        {
            this.activate = activate;
            this.party = party;
            this.idolId = idolId;
        }
        

public override void Serialize(IDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, activate);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, party);
            writer.WriteByte(flag1);
            writer.WriteVarShort((int)idolId);
            

}

public override void Deserialize(IDataReader reader)
{

byte flag1 = reader.ReadByte();
            activate = BooleanByteWrapper.GetFlag(flag1, 0);
            party = BooleanByteWrapper.GetFlag(flag1, 1);
            idolId = reader.ReadVarUhShort();
            

}


}


}