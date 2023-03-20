


















// Generated on 01/22/2023 17:43:01
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class TrustStatusMessage : Dofus2Message
{

public const uint Id = 6065;
public override uint MessageId
{
    get { return Id; }
}

public bool trusted;
        public bool certified;
        

public TrustStatusMessage()
{
}

public TrustStatusMessage(bool trusted, bool certified)
        {
            this.trusted = trusted;
            this.certified = certified;
        }
        

public override void Serialize(IDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, trusted);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, certified);
            writer.WriteByte(flag1);
            

}

public override void Deserialize(IDataReader reader)
{

byte flag1 = reader.ReadByte();
            trusted = BooleanByteWrapper.GetFlag(flag1, 0);
            certified = BooleanByteWrapper.GetFlag(flag1, 1);
            

}


}


}