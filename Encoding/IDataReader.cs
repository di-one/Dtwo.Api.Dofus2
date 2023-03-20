using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.Dofus2.Encoding
{
    public interface IDataReader : IDisposable
    {
        long Position { get; }

        long BytesAvailable { get; }

        byte[] Data { get; }

        short ReadShort();

        int ReadInt();

        long ReadLong();

        ushort ReadUShort();

        uint ReadUInt();

        ulong ReadULong();

        byte ReadByte();

        sbyte ReadSbyte();

        sbyte ReadSByte();

        byte[] ReadBytes(int n);

        bool ReadBoolean();

        char ReadChar();

        double ReadDouble();

        float ReadFloat();

        string ReadUTF();

        string ReadUTFBytes(ushort len);

        void Seek(int offset, SeekOrigin seekOrigin);

        void SkipBytes(int n);

        ulong ReadVarULong();

        ushort ReadVarUShort();
        short ReadVarShort();

        uint ReadVarUhShort();

        int ReadVarInt();

        long ReadVarLong();

        uint ReadVarUInt();

        double ReadVarUhLong();

        uint ReadVarUhInt();
    }
}
