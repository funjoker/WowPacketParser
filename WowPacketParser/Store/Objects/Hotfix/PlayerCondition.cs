using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.PlayerCondition)]
    [DBTableName("CHANGEME")]
    public sealed class PlayerCondition : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public long? RaceMask;
        
        [DBFieldName("CHANGEME")]
        public string FailureDescription;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public ushort? MinLevel;
        
        [DBFieldName("CHANGEME")]
        public ushort? MaxLevel;
        
        [DBFieldName("CHANGEME")]
        public int? ClassMask;
        
        [DBFieldName("CHANGEME")]
        public uint? SkillLogic;
        
        [DBFieldName("CHANGEME")]
        public byte? LanguageID;
        
        [DBFieldName("CHANGEME")]
        public byte? MinLanguage;
        
        [DBFieldName("CHANGEME")]
        public int? MaxLanguage;
        
        [DBFieldName("CHANGEME")]
        public ushort? MaxFactionID;
        
        [DBFieldName("CHANGEME")]
        public byte? MaxReputation;
        
        [DBFieldName("CHANGEME")]
        public uint? ReputationLogic;
        
        [DBFieldName("CHANGEME")]
        public sbyte? CurrentPvpFaction;
        
        [DBFieldName("CHANGEME")]
        public byte? PvpMedal;
        
        [DBFieldName("CHANGEME")]
        public uint? PrevQuestLogic;
        
        [DBFieldName("CHANGEME")]
        public uint? CurrQuestLogic;
        
        [DBFieldName("CHANGEME")]
        public uint? CurrentCompletedQuestLogic;
        
        [DBFieldName("CHANGEME")]
        public uint? SpellLogic;
        
        [DBFieldName("CHANGEME")]
        public uint? ItemLogic;
        
        [DBFieldName("CHANGEME")]
        public byte? ItemFlags;
        
        [DBFieldName("CHANGEME")]
        public uint? AuraSpellLogic;
        
        [DBFieldName("CHANGEME")]
        public ushort? WorldStateExpressionID;
        
        [DBFieldName("CHANGEME")]
        public byte? WeatherID;
        
        [DBFieldName("CHANGEME")]
        public byte? PartyStatus;
        
        [DBFieldName("CHANGEME")]
        public byte? LifetimeMaxPVPRank;
        
        [DBFieldName("CHANGEME")]
        public uint? AchievementLogic;
        
        [DBFieldName("CHANGEME")]
        public sbyte? Gender;
        
        [DBFieldName("CHANGEME")]
        public sbyte? NativeGender;
        
        [DBFieldName("CHANGEME")]
        public uint? AreaLogic;
        
        [DBFieldName("CHANGEME")]
        public uint? LfgLogic;
        
        [DBFieldName("CHANGEME")]
        public uint? CurrencyLogic;
        
        [DBFieldName("CHANGEME")]
        public ushort? QuestKillID;
        
        [DBFieldName("CHANGEME")]
        public uint? QuestKillLogic;
        
        [DBFieldName("CHANGEME")]
        public sbyte? MinExpansionLevel;
        
        [DBFieldName("CHANGEME")]
        public sbyte? MaxExpansionLevel;
        
        [DBFieldName("CHANGEME")]
        public int? MinAvgItemLevel;
        
        [DBFieldName("CHANGEME")]
        public int? MaxAvgItemLevel;
        
        [DBFieldName("CHANGEME")]
        public ushort? MinAvgEquippedItemLevel;
        
        [DBFieldName("CHANGEME")]
        public ushort? MaxAvgEquippedItemLevel;
        
        [DBFieldName("CHANGEME")]
        public byte? PhaseUseFlags;
        
        [DBFieldName("CHANGEME")]
        public ushort? PhaseID;
        
        [DBFieldName("CHANGEME")]
        public uint? PhaseGroupID;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public sbyte? ChrSpecializationIndex;
        
        [DBFieldName("CHANGEME")]
        public sbyte? ChrSpecializationRole;
        
        [DBFieldName("CHANGEME")]
        public uint? ModifierTreeID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? PowerType;
        
        [DBFieldName("CHANGEME")]
        public byte? PowerTypeComp;
        
        [DBFieldName("CHANGEME")]
        public byte? PowerTypeValue;
        
        [DBFieldName("CHANGEME")]
        public int? WeaponSubclassMask;
        
        [DBFieldName("CHANGEME")]
        public byte? MaxGuildLevel;
        
        [DBFieldName("CHANGEME")]
        public byte? MinGuildLevel;
        
        [DBFieldName("CHANGEME")]
        public sbyte? MaxExpansionTier;
        
        [DBFieldName("CHANGEME")]
        public sbyte? MinExpansionTier;
        
        [DBFieldName("CHANGEME")]
        public byte? MinPVPRank;
        
        [DBFieldName("CHANGEME")]
        public byte? MaxPVPRank;
        
        [HotfixArray(4)]
        public ushort?[] SkillID;
        
        [HotfixArray(4)]
        public ushort?[] MinSkill;
        
        [HotfixArray(4)]
        public ushort?[] MaxSkill;
        
        [HotfixArray(3)]
        public uint?[] MinFactionID;
        
        [HotfixArray(3)]
        public byte?[] MinReputation;
        
        [HotfixArray(4)]
        public ushort?[] PrevQuestID;
        
        [HotfixArray(4)]
        public ushort?[] CurrQuestID;
        
        [HotfixArray(4)]
        public ushort?[] CurrentCompletedQuestID;
        
        [HotfixArray(4)]
        public int?[] SpellID;
        
        [HotfixArray(4)]
        public int?[] ItemID;
        
        [HotfixArray(4)]
        public uint?[] ItemCount;
        
        [HotfixArray(2)]
        public ushort?[] Explored;
        
        [HotfixArray(2)]
        public uint?[] Time;
        
        [HotfixArray(4)]
        public int?[] AuraSpellID;
        
        [HotfixArray(4)]
        public byte?[] AuraStacks;
        
        [HotfixArray(4)]
        public ushort?[] Achievement;
        
        [HotfixArray(4)]
        public ushort?[] AreaID;
        
        [HotfixArray(4)]
        public byte?[] LfgStatus;
        
        [HotfixArray(4)]
        public byte?[] LfgCompare;
        
        [HotfixArray(4)]
        public uint?[] LfgValue;
        
        [HotfixArray(4)]
        public uint?[] CurrencyID;
        
        [HotfixArray(4)]
        public uint?[] CurrencyCount;
        
        [HotfixArray(6)]
        public uint?[] QuestKillMonster;
        
        [HotfixArray(2)]
        public int?[] MovementFlags;
    }
}
