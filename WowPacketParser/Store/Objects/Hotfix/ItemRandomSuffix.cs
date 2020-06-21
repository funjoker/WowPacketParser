using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemRandomSuffix, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemRandomSuffix : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [HotfixArray(5)]
        public ushort?[] Enchantment;
        
        [HotfixArray(5)]
        public ushort?[] AllocationPct;
    }
}
