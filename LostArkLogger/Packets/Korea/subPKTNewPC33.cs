using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public partial class subPKTNewPC33
    {
        public void KoreaDecode(BitReader reader)
        {
            u32_0 = reader.ReadUInt32();
            u32_1 = reader.ReadUInt32();
            b = reader.ReadByte();
            if (b == 1)
                bytearray_0 = reader.ReadBytes(12);
            bytearray_1 = reader.ReadBytes(12);
        }
    }
}
