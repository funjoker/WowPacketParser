using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.OverrideSpellData, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class OverrideSpellData : IDataModel
    {
        [HotfixArray(10)]
        public int?[] Spells;
        
        [DBFieldName("CHANGEME")]
        public int? PlayerActionBarFileDataID;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
    }
}
