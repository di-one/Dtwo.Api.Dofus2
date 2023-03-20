


















// Generated on 01/22/2023 17:42:40
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AccountLoggingKickedMessage : Dofus2Message
{

public const uint Id = 6526;
public override uint MessageId
{
    get { return Id; }
}

public uint days;
        public sbyte hours;
        public sbyte minutes;
        

public AccountLoggingKickedMessage()
{
}

public AccountLoggingKickedMessage(uint days, sbyte hours, sbyte minutes)
        {
            this.days = days;
            this.hours = hours;
            this.minutes = minutes;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)days);
            writer.WriteSbyte(hours);
            writer.WriteSbyte(minutes);
            

}

public override void Deserialize(IDataReader reader)
{

days = reader.ReadVarUhShort();
            hours = reader.ReadSbyte();
            minutes = reader.ReadSbyte();
            

}


}


}