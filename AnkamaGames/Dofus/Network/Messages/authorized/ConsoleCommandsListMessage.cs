


















// Generated on 01/22/2023 17:42:36
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ConsoleCommandsListMessage : Dofus2Message
{

public const uint Id = 6089;
public override uint MessageId
{
    get { return Id; }
}

public string[] aliases;
        public string[] args;
        public string[] descriptions;
        

public ConsoleCommandsListMessage()
{
}

public ConsoleCommandsListMessage(string[] aliases, string[] args, string[] descriptions)
        {
            this.aliases = aliases;
            this.args = args;
            this.descriptions = descriptions;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)aliases.Length);
            foreach (var entry in aliases)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteShort((short)args.Length);
            foreach (var entry in args)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteShort((short)descriptions.Length);
            foreach (var entry in descriptions)
            {
                 writer.WriteUTF(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            aliases = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 aliases[i] = reader.ReadUTF();
            }
            limit = (ushort)reader.ReadUShort();
            args = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 args[i] = reader.ReadUTF();
            }
            limit = (ushort)reader.ReadUShort();
            descriptions = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 descriptions[i] = reader.ReadUTF();
            }
            

}


}


}