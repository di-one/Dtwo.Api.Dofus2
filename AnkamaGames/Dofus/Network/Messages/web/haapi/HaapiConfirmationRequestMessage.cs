


















// Generated on 01/22/2023 17:43:02
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HaapiConfirmationRequestMessage : Dofus2Message
{

public const uint Id = 8461;
public override uint MessageId
{
    get { return Id; }
}

public double kamas;
        public double ogrines;
        public uint rate;
        public sbyte action;
        

public HaapiConfirmationRequestMessage()
{
}

public HaapiConfirmationRequestMessage(double kamas, double ogrines, uint rate, sbyte action)
        {
            this.kamas = kamas;
            this.ogrines = ogrines;
            this.rate = rate;
            this.action = action;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(kamas);
            writer.WriteVarLong(ogrines);
            writer.WriteVarShort((int)rate);
            writer.WriteSbyte(action);
            

}

public override void Deserialize(IDataReader reader)
{

kamas = reader.ReadVarUhLong();
            ogrines = reader.ReadVarUhLong();
            rate = reader.ReadVarUhShort();
            action = reader.ReadSbyte();
            

}


}


}