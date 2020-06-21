using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParserModule.V8_2_5_31921.Hotfix
{
    [HotfixStructure(DB2Hash.ItemSparse, ClientVersionBuild.V8_2_5_31921, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemSparse : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public long? AllowableRace;
        
        [DBFieldName("CHANGEME")]
        public string Description;
        
        [DBFieldName("CHANGEME")]
        public string Display3;
        
        [DBFieldName("CHANGEME")]
        public string Display2;
        
        [DBFieldName("CHANGEME")]
        public string Display1;
        
        [DBFieldName("CHANGEME")]
        public string Display;
        
        [DBFieldName("CHANGEME")]
        public float? DmgVariance;
        
        [DBFieldName("CHANGEME")]
        public uint? DurationInInventory;
        
        [DBFieldName("CHANGEME")]
        public float? QualityModifier;
        
        [DBFieldName("CHANGEME")]
        public uint? BagFamily;
        
        [DBFieldName("CHANGEME")]
        public float? ItemRange;
        
        [HotfixArray(10)]
        public float?[] StatPercentageOfSocket;
        
        [HotfixArray(10)]
        public int?[] StatPercentEditor;
        
        [DBFieldName("CHANGEME")]
        public int? Stackable;
        
        [DBFieldName("CHANGEME")]
        public int? MaxCount;
        
        [DBFieldName("CHANGEME")]
        public uint? RequiredAbility;
        
        [DBFieldName("CHANGEME")]
        public uint? SellPrice;
        
        [DBFieldName("CHANGEME")]
        public uint? BuyPrice;
        
        [DBFieldName("CHANGEME")]
        public uint? VendorStackCount;
        
        [DBFieldName("CHANGEME")]
        public float? PriceVariance;
        
        [DBFieldName("CHANGEME")]
        public float? PriceRandomValue;
        
        [HotfixArray(4)]
        public int?[] Flags;
        
        [DBFieldName("CHANGEME")]
        public int? FactionRelated;
        
        [DBFieldName("CHANGEME")]
        public ushort? ItemNameDescriptionID;
        
        [DBFieldName("CHANGEME")]
        public ushort? RequiredTransmogHoliday;
        
        [DBFieldName("CHANGEME")]
        public ushort? RequiredHoliday;
        
        [DBFieldName("CHANGEME")]
        public ushort? LimitCategory;
        
        [DBFieldName("CHANGEME")]
        public ushort? GemProperties;
        
        [DBFieldName("CHANGEME")]
        public ushort? SocketMatchEnchantmentId;
        
        [DBFieldName("CHANGEME")]
        public ushort? TotemCategoryID;
        
        [DBFieldName("CHANGEME")]
        public ushort? InstanceBound;
        
        [HotfixArray(2)]
        public ushort?[] ZoneBound;
        
        [DBFieldName("CHANGEME")]
        public ushort? ItemSet;
        
        [DBFieldName("CHANGEME")]
        public ushort? LockID;
        
        [DBFieldName("CHANGEME")]
        public ushort? StartQuestID;
        
        [DBFieldName("CHANGEME")]
        public ushort? PageID;
        
        [DBFieldName("CHANGEME")]
        public ushort? ItemDelay;
        
        [DBFieldName("CHANGEME")]
        public ushort? ScalingStatDistributionID;
        
        [DBFieldName("CHANGEME")]
        public ushort? MinFactionID;
        
        [DBFieldName("CHANGEME")]
        public ushort? RequiredSkillRank;
        
        [DBFieldName("CHANGEME")]
        public ushort? RequiredSkill;
        
        [DBFieldName("CHANGEME")]
        public ushort? ItemLevel;
        
        [DBFieldName("CHANGEME")]
        public short? AllowableClass;
        
        [DBFieldName("CHANGEME")]
        public byte? ExpansionID;
        
        [DBFieldName("CHANGEME")]
        public byte? ArtifactID;
        
        [DBFieldName("CHANGEME")]
        public byte? SpellWeight;
        
        [DBFieldName("CHANGEME")]
        public byte? SpellWeightCategory;
        
        [HotfixArray(3)]
        public byte?[] SocketType;
        
        [DBFieldName("CHANGEME")]
        public byte? SheatheType;
        
        [DBFieldName("CHANGEME")]
        public byte? Material;
        
        [DBFieldName("CHANGEME")]
        public byte? PageMaterialID;
        
        [DBFieldName("CHANGEME")]
        public byte? LanguageID;
        
        [DBFieldName("CHANGEME")]
        public byte? Bonding;
        
        [DBFieldName("CHANGEME")]
        public byte? DamageDamageType;
        
        [HotfixArray(10)]
        public sbyte?[] StatModifierBonusStat;
        
        [DBFieldName("CHANGEME")]
        public byte? ContainerSlots;
        
        [DBFieldName("CHANGEME")]
        public byte? MinReputation;
        
        [DBFieldName("CHANGEME")]
        public byte? RequiredPVPMedal;
        
        [DBFieldName("CHANGEME")]
        public byte? RequiredPVPRank;
        
        [DBFieldName("CHANGEME")]
        public sbyte? RequiredLevel;
        
        [DBFieldName("CHANGEME")]
        public byte? InventoryType;
        
        [DBFieldName("CHANGEME")]
        public byte? OverallQualityID;
    }
}
