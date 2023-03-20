


















// Generated on 01/22/2023 17:43:02
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HaapiConfirmationMessage : Dofus2Message
{

public const uint Id = 7027;
public override uint MessageId
{
    get { return Id; }
}

public double kamas;
        public double amount;
        public uint rate;
        public sbyte action;
        public string transaction;
        

public HaapiConfirmationMessage()
{
}

public HaapiConfirmationMessage(double kamas, double amount, uint rate, sbyte action, string transaction)
        {
            this.kamas = kamas;
            this.amount = amount;
            this.rate = rate;
            this.action = action;
            this.transaction = transaction;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(kamas);
            writer.WriteVarLong(amount);
            writer.WriteVarShort((int)rate);
            writer.WriteSbyte(action);
            writer.WriteUTF(transaction);
            

}

public override void Deserialize(IDataReader reader)
{

kamas = reader.ReadVarUhLong();
            amount = reader.ReadVarUhLong();
            rate = reader.ReadVarUhShort();
            action = reader.ReadSbyte();
            transaction = reader.ReadUTF();
            

}


}


}