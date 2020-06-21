using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SkillLineAbility)]
    [DBTableName("CHANGEME")]
    public sealed class SkillLineAbility : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public long? RaceMask;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public short? SkillLine;
        
        [DBFieldName("CHANGEME")]
        public int? Spell;
        
        [DBFieldName("CHANGEME")]
        public short? MinSkillLineRank;
        
        [DBFieldName("CHANGEME")]
        public int? ClassMask;
        
        [DBFieldName("CHANGEME")]
        public int? SupercedesSpell;
        
        [DBFieldName("CHANGEME")]
        public sbyte? AcquireMethod;
        
        [DBFieldName("CHANGEME")]
        public short? TrivialSkillLineRankHigh;
        
        [DBFieldName("CHANGEME")]
        public short? TrivialSkillLineRankLow;
        
        [DBFieldName("CHANGEME")]
        public sbyte? Flags;
        
        [DBFieldName("CHANGEME")]
        public sbyte? NumSkillUps;
        
        [DBFieldName("CHANGEME")]
        public short? UniqueBit;
        
        [DBFieldName("CHANGEME")]
        public short? TradeSkillCategoryID;
        
        [DBFieldName("CHANGEME")]
        public short? SkillupSkillLineID;
    }
}
