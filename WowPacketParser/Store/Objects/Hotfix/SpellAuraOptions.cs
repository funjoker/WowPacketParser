using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellAuraOptions, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellAuraOptions : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? DifficultyID;
        
        [DBFieldName("CHANGEME")]
        public ushort? CumulativeAura;
        
        [DBFieldName("CHANGEME")]
        public int? ProcCategoryRecovery;
        
        [DBFieldName("CHANGEME")]
        public byte? ProcChance;
        
        [DBFieldName("CHANGEME")]
        public int? ProcCharges;
        
        [DBFieldName("CHANGEME")]
        public ushort? SpellProcsPerMinuteID;
        
        [HotfixArray(2)]
        public int?[] ProcTypeMask;
        
        [DBFieldName("CHANGEME")]
        public int? SpellID;
    }
}
