using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellShapeshift, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellShapeshift : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? SpellID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? StanceBarOrder;
        
        [HotfixArray(2)]
        public int?[] ShapeshiftExclude;
        
        [HotfixArray(2)]
        public int?[] ShapeshiftMask;
    }
}
