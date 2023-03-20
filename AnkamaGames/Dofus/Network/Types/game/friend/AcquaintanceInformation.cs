


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class AcquaintanceInformation : AbstractContactInformations
{

public const short Id = 6961;
public override short TypeId
{
    get { return Id; }
}

public sbyte playerState;
        

public AcquaintanceInformation()
{
}

public AcquaintanceInformation(int accountId, Types.AccountTagInformation accountTag, sbyte playerState)
         : base(accountId, accountTag)
        {
            this.playerState = playerState;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(playerState);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            playerState = reader.ReadSbyte();
            

}


}


}