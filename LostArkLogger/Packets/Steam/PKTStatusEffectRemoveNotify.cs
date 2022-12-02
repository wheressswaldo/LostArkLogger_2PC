using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public partial class PKTStatusEffectRemoveNotify
    {
        public void SteamDecode(BitReader reader)
        {
            Reason = reader.ReadByte();
            InstanceIds = reader.ReadList<UInt32>();
            ObjectId = reader.ReadUInt64();
        }
    }
}
