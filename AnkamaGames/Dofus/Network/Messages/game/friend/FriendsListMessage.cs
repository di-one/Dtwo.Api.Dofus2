


















// Generated on 01/22/2023 17:42:52
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class FriendsListMessage : Dofus2Message
{

public const uint Id = 7934;
public override uint MessageId
{
    get { return Id; }
}

public Types.FriendInformations[] friendsList;
        

public FriendsListMessage()
{
}

public FriendsListMessage(Types.FriendInformations[] friendsList)
        {
            this.friendsList = friendsList;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)friendsList.Length);
            foreach (var entry in friendsList)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            friendsList = new Types.FriendInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 friendsList[i] = ProtocolTypeManager.GetInstance<Types.FriendInformations>(reader.ReadUShort());
                 friendsList[i].Deserialize(reader);
            }
            

}


}


}