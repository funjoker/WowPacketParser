using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.PvpTalent)]
    [DBTableName("CHANGEME")]
    public sealed class PvpTalent : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Description;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public int? SpecID;
        
        [DBFieldName("CHANGEME")]
        public int? SpellID;
        
        [DBFieldName("CHANGEME")]
        public int? OverridesSpellID;
        
        [DBFieldName("CHANGEME")]
        public int? Flags;
        
        [DBFieldName("CHANGEME")]
        public int? ActionBarSpellID;
        
        [DBFieldName("CHANGEME")]
        public int? PvpTalentCategoryID;
        
        [DBFieldName("CHANGEME")]
        public int? LevelRequired;
    }
}
