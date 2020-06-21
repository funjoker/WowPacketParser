using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.LfgDungeons, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class LfgDungeons : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public string Description;
        
        [DBFieldName("CHANGEME")]
        public byte? MinLevel;
        
        [DBFieldName("CHANGEME")]
        public ushort? MaxLevel;
        
        [DBFieldName("CHANGEME")]
        public byte? TypeID;
        
        [DBFieldName("CHANGEME")]
        public byte? Subtype;
        
        [DBFieldName("CHANGEME")]
        public sbyte? Faction;
        
        [DBFieldName("CHANGEME")]
        public int? IconTextureFileID;
        
        [DBFieldName("CHANGEME")]
        public int? RewardsBgTextureFileID;
        
        [DBFieldName("CHANGEME")]
        public int? PopupBgTextureFileID;
        
        [DBFieldName("CHANGEME")]
        public byte? ExpansionLevel;
        
        [DBFieldName("CHANGEME")]
        public short? MapID;
        
        [DBFieldName("CHANGEME")]
        public byte? DifficultyID;
        
        [DBFieldName("CHANGEME")]
        public float? MinGear;
        
        [DBFieldName("CHANGEME")]
        public byte? GroupID;
        
        [DBFieldName("CHANGEME")]
        public byte? OrderIndex;
        
        [DBFieldName("CHANGEME")]
        public uint? RequiredPlayerConditionId;
        
        [DBFieldName("CHANGEME")]
        public byte? TargetLevel;
        
        [DBFieldName("CHANGEME")]
        public byte? TargetLevelMin;
        
        [DBFieldName("CHANGEME")]
        public ushort? TargetLevelMax;
        
        [DBFieldName("CHANGEME")]
        public ushort? RandomID;
        
        [DBFieldName("CHANGEME")]
        public ushort? ScenarioID;
        
        [DBFieldName("CHANGEME")]
        public ushort? FinalEncounterID;
        
        [DBFieldName("CHANGEME")]
        public byte? CountTank;
        
        [DBFieldName("CHANGEME")]
        public byte? CountHealer;
        
        [DBFieldName("CHANGEME")]
        public byte? CountDamage;
        
        [DBFieldName("CHANGEME")]
        public byte? MinCountTank;
        
        [DBFieldName("CHANGEME")]
        public byte? MinCountHealer;
        
        [DBFieldName("CHANGEME")]
        public byte? MinCountDamage;
        
        [DBFieldName("CHANGEME")]
        public ushort? BonusReputationAmount;
        
        [DBFieldName("CHANGEME")]
        public ushort? MentorItemLevel;
        
        [DBFieldName("CHANGEME")]
        public byte? MentorCharLevel;
        
        [HotfixArray(2)]
        public int?[] Flags;
    }
}
