﻿#region License GNU GPL
//FastBigEndianReader.cs

//Copyright(C) 2012 - BehaviorIsManaged


// This program is free software; you can redistribute it and/or modify it 
// under the terms of the GNU General Public License as published by the Free Software Foundation;
//either version 2 of the License, or (at your option) any later version.

// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
//without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
// See the GNU General Public License for more details. 
// You should have received a copy of the GNU General Public License along with this program;
//if not, write to the Free Software Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
#endregion

using System.Text;

namespace Dtwo.API.Dofus2.Encoding
{
    /// <summary>
    /// Much faster reader that only reads memory buffer
    /// </summary>
    public unsafe class FastBigEndianReader : IDataReader, IDisposable
    {
        public FastBigEndianReader(byte[] buffer)
        {
            Buffer = buffer;
        }

        public byte[] Data
        {
            get
            {
                return Buffer;
            }
        }

        public byte[] Buffer { get; set; }

        public byte ReadByte()
        {
            fixed (byte* pbyte = &Buffer[Position++])
            {
                return *pbyte;
            }
        }

        public sbyte ReadSbyte()
        {
            fixed (byte* pbyte = &Buffer[Position++])
            {
                return (sbyte)*pbyte;
            }
        }

        public long Position { get; private set; }

        public long BytesAvailable
        {
            get { return Buffer.Length - Position; }
        }

        public short ReadShort()
        {
            var position = Position;
            Position += 2;
            fixed (byte* pbyte = &Buffer[position])
            {
                return (short)((*pbyte << 8) | *(pbyte + 1));
            }
        }

        public int ReadInt()
        {
            var position = Position;
            Position += 4;
            fixed (byte* pbyte = &Buffer[position])
            {
                return (*pbyte << 24) | (*(pbyte + 1) << 16) | (*(pbyte + 2) << 8) | *(pbyte + 3);
            }
        }

        public long ReadLong()
        {
            var position = Position;
            Position += 8;
            fixed (byte* pbyte = &Buffer[position])
            {
                var i1 = (*pbyte << 24) | (*(pbyte + 1) << 16) | (*(pbyte + 2) << 8) | *(pbyte + 3);
                var i2 = (*(pbyte + 4) << 24) | (*(pbyte + 5) << 16) | (*(pbyte + 6) << 8) | *(pbyte + 7);
                return (uint)i2 | ((long)i1 << 32);
            }
        }

        public ushort ReadUShort()
        {
            return (ushort)ReadShort();
        }

        public uint ReadUInt()
        {
            return (uint)ReadInt();
        }

        public ulong ReadULong()
        {
            return (ulong)ReadLong();
        }

        public byte[] ReadBytes(int n)
        {
            var dst = new byte[n];
            fixed (byte* pSrc = &Buffer[Position], pDst = dst)
            {
                var ps = pSrc;
                var pd = pDst;

                // Loop over the count in blocks of 4 bytes, copying an integer (4 bytes) at a time:
                for (var i = 0; i < n / 4; i++)
                {
                    *(int*)pd = *(int*)ps;
                    pd += 4;
                    ps += 4;
                }

                // Complete the copy by moving any bytes that weren't moved in blocks of 4:
                for (var i = 0; i < n % 4; i++)
                {
                    *pd = *ps;
                    pd++;
                    ps++;
                }
            }

            Position += n;

            return dst;
        }

        public bool ReadBoolean()
        {
            return ReadByte() != 0;
        }

        public char ReadChar()
        {
            return (char)ReadShort();
        }

        public float ReadFloat()
        {
            var val = ReadInt();
            return *(float*)&val;
        }

        public double ReadDouble()
        {
            var val = ReadLong();
            return *(double*)&val;
        }

        public string ReadUTF()
        {
            var length = ReadUShort();

            var bytes = ReadBytes(length);
            return System.Text.Encoding.UTF8.GetString(bytes);
        }

        public string ReadUTFBytes(ushort len)
        {
            var bytes = ReadBytes(len);
            return System.Text.Encoding.UTF8.GetString(bytes);
        }

        public void Seek(int offset, SeekOrigin seekOrigin)
        {
            if (seekOrigin == SeekOrigin.Begin)
                Position = offset;
            else if (seekOrigin == SeekOrigin.End)
                Position = Buffer.Length + offset;
            else if (seekOrigin == SeekOrigin.Current)
                Position += offset;
        }

        public void SkipBytes(int n)
        {
            Position += n;
        }

        public void Dispose()
        {
        }

        #region Custom Methods

        public short ReadVarShort()
        {
            throw new NotImplementedException();
        }

        public ushort ReadVarUShort()
        {
            throw new NotImplementedException();
        }

        public int ReadVarInt()
        {
            throw new NotImplementedException();
        }

        public uint ReadVarUInt()
        {
            throw new NotImplementedException();
        }

        public long ReadVarLong()
        {
            throw new NotImplementedException();
        }

        public ulong ReadVarULong()
        {
            throw new NotImplementedException();
        }

        public uint ReadVarUhShort()
        {
            return (uint)(ReadVarShort());
        }

        public double ReadVarUhLong()
        {
            return ReadUInt();
        }

        public uint ReadVarUhInt()
        {
            return (uint)(ReadVarInt());
        }

        public sbyte ReadSByte()
        {
            return ReadSbyte();
        }
        #endregion
    }
}