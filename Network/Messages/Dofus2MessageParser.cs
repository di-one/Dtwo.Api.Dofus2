using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.DofusBase.Network.Messages;

namespace Dtwo.API.Dofus2.Network.Messages
{
    public class Dofus2MessageParser : MessageParser
    {
        private BigEndianReader m_buffer;
        private MessagePart m_currentMessage;


        public override void OnGetPacket(byte[] data, int length)
        {
            if (m_buffer == null)
            {
                m_buffer = new BigEndianReader();
            }

            //Console.WriteLine("On get packet");

            if (data != null)
            {
                byte[] newData = new byte[length];
                Array.Copy(data, newData, length);
                m_buffer.Add(data, 0, data.Length);
                ThreatBuffer();
            }
        }

        private void ThreatBuffer()
        {
            //Console.WriteLine("ThreatBuffer");

            if (m_currentMessage == null)
                m_currentMessage = new MessagePart();

            long pos = m_buffer.Position;

            if (m_currentMessage.Build(m_buffer, false))
            {
                OnDataReceived(m_currentMessage);
                m_currentMessage = null;
                ThreatBuffer();
            }
            else
            {
                //Console.WriteLine("cant paser packet");
                //LogManager.Log("PacketAnalyzer", "Cant build packet");
                //System.Console.WriteLine("Cant build packet");
            }
        }

        private void OnDataReceived(MessagePart part)
        {
            try
            {
                var messageDataReader = new BigEndianReader(part.Data);

                var message = Reflection.Dofus2MessagesLoader.Instance.GetMessage(part.MessageId.ToString());

                if (message == null)
                {
                    //error
                    return;
                }

                try
                {
                    message.Unpack(messageDataReader);
                }
                catch (Exception ex)
                {
                    //error
                    LogManager.LogError("Error on data received : " + ex.ToString());
                    return;
                }

                OnGetMessage?.Invoke(message.MessageId.ToString(), message);

                if (!message.Cancel)
                {
                    messageDataReader.Dispose();
                    message = null;
                }
            }
            catch (Exception ex)
            {
                LogManager.LogError("[Network] ClientDataReceived Function -> " + ex.Message);
            }
        }
    }
}
