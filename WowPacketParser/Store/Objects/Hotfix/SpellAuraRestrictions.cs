using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellAuraRestrictions, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellAuraRestrictions : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? DifficultyID;
        
        [DBFieldName("CHANGEME")]
        public byte? CasterAuraState;
        
        [DBFieldName("CHANGEME")]
        public byte? TargetAuraState;
        
        [DBFieldName("CHANGEME")]
        public byte? ExcludeCasterAuraState;
        
        [DBFieldName("CHANGEME")]
        public byte? ExcludeTargetAuraState;
        
        [DBFieldName("CHANGEME")]
        public int? CasterAuraSpell;
        
        [DBFieldName("CHANGEME")]
        public int? TargetAuraSpell;
        
        [DBFieldName("CHANGEME")]
        public int? ExcludeCasterAuraSpell;
        
        [DBFieldName("CHANGEME")]
        public int? ExcludeTargetAuraSpell;
        
        [DBFieldName("CHANGEME")]
        public int? SpellID;
    }
}
