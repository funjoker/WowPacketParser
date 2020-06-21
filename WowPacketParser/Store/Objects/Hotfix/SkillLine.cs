using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SkillLine)]
    [DBTableName("CHANGEME")]
    public sealed class SkillLine : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string DisplayName;
        
        [DBFieldName("CHANGEME")]
        public string AlternateVerb;
        
        [DBFieldName("CHANGEME")]
        public string Description;
        
        [DBFieldName("CHANGEME")]
        public string HordeDisplayName;
        
        [DBFieldName("CHANGEME")]
        public string OverrideSourceInfoDisplayName;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? CategoryID;
        
        [DBFieldName("CHANGEME")]
        public int? SpellIconFileID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? CanLink;
        
        [DBFieldName("CHANGEME")]
        public uint? ParentSkillLineID;
        
        [DBFieldName("CHANGEME")]
        public int? ParentTierIndex;
        
        [DBFieldName("CHANGEME")]
        public ushort? Flags;
        
        [DBFieldName("CHANGEME")]
        public int? SpellBookSpellID;
    }
}
