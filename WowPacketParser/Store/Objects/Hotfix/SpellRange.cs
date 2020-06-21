using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellRange, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellRange : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string DisplayName;
        
        [DBFieldName("CHANGEME")]
        public string DisplayNameShort;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [HotfixArray(2)]
        public float?[] RangeMin;
        
        [HotfixArray(2)]
        public float?[] RangeMax;
    }
}
