using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.DofusBase.Network.Messages;

namespace Dtwo.API.Dofus2.Network.Messages
{
    [Serializable]
    public abstract class Dofus2Message : DofusMessage
    {
        private const byte BIT_RIGHT_SHIFT_LEN_PACKET_ID = 2;
        private const byte BIT_MASK = 3;

        public bool Cancel = false;
        public abstract uint MessageId { get; }

        public void Unpack(IDataReader reader)
        {
            Deserialize(reader);
        }

        public void Pack(IDataWriter writer, uint instance = 0)
        {
            Serialize(writer);
            WritePacket(writer, instance);
        }

        public abstract void Serialize(IDataWriter writer);
        public abstract void Deserialize(IDataReader reader);
        private void WritePacket(IDataWriter writer, uint instance = 0)
        {
            byte[] packet = writer.Data;

            writer.Clear();

            byte typeLen = ComputeTypeLen(packet.Length);
            var header = (short)SubComputeStaticHeader(MessageId, typeLen);
            writer.WriteShort(header);

            if (instance != 0)
                writer.WriteUInt(instance);

            switch (typeLen)
            {
                case 0:
                    break;
                case 1:
                    writer.WriteByte((byte)packet.Length);
                    break;
                case 2:
                    writer.WriteShort((short)packet.Length);
                    break;
                case 3:
                    writer.WriteByte((byte)(packet.Length >> 16 & 255));
                    writer.WriteShort((short)(packet.Length & 65535));
                    break;
                default:
                    throw new System.Exception("Packet's length can't be encoded on 4 or more bytes");
            }
            writer.WriteBytes(packet);
        }
        private static byte ComputeTypeLen(int param1)
        {
            if (param1 > 65535)
                return 3;

            if (param1 > 255)
                return 2;

            if (param1 > 0)
                return 1;

            return 0;
        }

        private static uint SubComputeStaticHeader(uint id, byte typeLen)
        {
            return id << BIT_RIGHT_SHIFT_LEN_PACKET_ID | typeLen;
        }

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
