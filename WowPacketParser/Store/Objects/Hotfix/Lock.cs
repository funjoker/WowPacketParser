using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.Lock, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class Lock : IDataModel
    {
        [HotfixArray(8)]
        public int?[] Index;
        
        [HotfixArray(8)]
        public ushort?[] Skill;
        
        [HotfixArray(8)]
        public byte?[] Type;
        
        [HotfixArray(8)]
        public byte?[] Action;
    }
}
