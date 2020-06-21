using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemSearchName)]
    [DBTableName("CHANGEME")]
    public sealed class ItemSearchName : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public long? AllowableRace;
        
        [DBFieldName("CHANGEME")]
        public string Display;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public byte? OverallQualityID;
        
        [DBFieldName("CHANGEME")]
        public byte? ExpansionID;
        
        [DBFieldName("CHANGEME")]
        public ushort? MinFactionID;
        
        [DBFieldName("CHANGEME")]
        public byte? MinReputation;
        
        [DBFieldName("CHANGEME")]
        public int? AllowableClass;
        
        [DBFieldName("CHANGEME")]
        public sbyte? RequiredLevel;
        
        [DBFieldName("CHANGEME")]
        public ushort? RequiredSkill;
        
        [DBFieldName("CHANGEME")]
        public ushort? RequiredSkillRank;
        
        [DBFieldName("CHANGEME")]
        public uint? RequiredAbility;
        
        [DBFieldName("CHANGEME")]
        public ushort? ItemLevel;
        
        [HotfixArray(4)]
        public int?[] Flags;
    }
}
