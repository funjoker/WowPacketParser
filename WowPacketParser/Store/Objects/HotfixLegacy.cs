using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("hotfix_data")]
    public sealed class HotfixData434 : IDataModel
    {
        [DBFieldName("Timestamp", true)]
        public uint? Timestamp;

        [DBFieldName("TableHash", true)]
        public DB2Hash? TableHash;

        [DBFieldName("RecordId", true)]
        public int? RecordID;

        [DBFieldName("Deleted")]
        public bool? Deleted;
    }

    [DBTableName("item_currency_cost")]
    public sealed class ItemCurrencyCost434 : IDataModel
    {
        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("ItemID")]
        public int? ItemID;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }

    [DBTableName("item")]
    public sealed class Item434 : IDataModel
    {
        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("ClassID")]
        public int? ClassID;

        [DBFieldName("SubclassID")]
        public uint? SubclassID;

        [DBFieldName("SoundOverrideSubclassID")]
        public int? SoundOverrideSubclassID;

        [DBFieldName("Material")]
        public int? Material;

        [DBFieldName("DisplayInfoID")]
        public uint? DisplayInfoID;

        [DBFieldName("InventoryType")]
        public uint? InventoryType;

        [DBFieldName("SheatheType")]
        public int? SheatheType;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }

    [DBTableName("item_extended_cost")]
    public sealed class ItemExtendedCost434 : IDataModel
    {
        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("RequiredHonorPoints")]
        public uint? RequiredHonorPoints;

        [DBFieldName("RequiredArenaPoints")]
        public uint? RequiredArenaPoints;

        [DBFieldName("RequiredArenaSlot")]
        public uint? RequiredArenaSlot;

        [DBFieldName("RequiredItem", 5)]
        public uint?[] RequiredItem;

        [DBFieldName("RequiredItemCount", 5)]
        public uint?[] RequiredItemCount;

        [DBFieldName("RequiredPersonalArenaRating")]
        public uint? RequiredPersonalArenaRating;

        [DBFieldName("ItemPurchaseGroup")]
        public uint? ItemPurchaseGroup;

        [DBFieldName("RequiredCurrency", 5)]
        public uint?[] RequiredCurrency;

        [DBFieldName("RequiredCurrencyCount", 5)]
        public uint?[] RequiredCurrencyCount;

        [DBFieldName("RequiredFactionId")]
        public uint? RequiredFactionId;

        [DBFieldName("RequiredFactionStanding")]
        public uint? RequiredFactionStanding;

        [DBFieldName("RequirementFlags")]
        public uint? RequirementFlags;

        [DBFieldName("RequiredAchievement")]
        public uint? RequiredAchievement;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }

    [DBTableName("item_sparse")]
    public sealed class ItemSparse434 : IDataModel
    {
        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("Quality")]
        public int? Quality;

        [DBFieldName("Flags", 2)]
        public uint?[] Flags;

        [DBFieldName("PriceRandomValue")]
        public float? PriceRandomValue;

        [DBFieldName("PriceVariance")]
        public float? PriceVariance;

        [DBFieldName("BuyCount")]
        public uint? BuyCount;

        [DBFieldName("BuyPrice")]
        public uint? BuyPrice;

        [DBFieldName("SellPrice")]
        public uint? SellPrice;

        [DBFieldName("InventoryType")]
        public int? InventoryType;

        [DBFieldName("AllowableClass")]
        public int? AllowableClass;

        [DBFieldName("AllowableRace")]
        public int? AllowableRace;

        [DBFieldName("ItemLevel")]
        public uint? ItemLevel;

        [DBFieldName("RequiredLevel")]
        public uint? RequiredLevel;

        [DBFieldName("RequiredSkill")]
        public uint? RequiredSkill;

        [DBFieldName("RequiredSkillRank")]
        public uint? RequiredSkillRank;

        [DBFieldName("RequiredSpell")]
        public int? RequiredSpell;

        [DBFieldName("RequiredHonorRank")]
        public uint? RequiredHonorRank;

        [DBFieldName("RequiredCityRank")]
        public uint? RequiredCityRank;

        [DBFieldName("RequiredReputationFaction")]
        public uint? RequiredReputationFaction;

        [DBFieldName("RequiredReputationRank")]
        public uint? RequiredReputationRank;

        [DBFieldName("MaxCount")]
        public int? MaxCount;

        [DBFieldName("Stackable")]
        public int? Stackable;

        [DBFieldName("ContainerSlots")]
        public uint? ContainerSlots;

        [DBFieldName("ItemStatType", 10)]
        public int?[] ItemStatType;

        [DBFieldName("ItemStatValue", 10)]
        public int?[] ItemStatValue;

        [DBFieldName("ItemStatAllocation", 10)]
        public int?[] ItemStatAllocation;

        [DBFieldName("ItemStatSocketCostMultiplier", 10)]
        public int?[] ItemStatSocketCostMultiplier;

        [DBFieldName("ScalingStatDistribution")]
        public int? ScalingStatDistribution;

        [DBFieldName("DamageType")]
        public int? DamageType;

        [DBFieldName("Delay")]
        public uint? Delay;

        [DBFieldName("RangedModRange")]
        public float? RangedModRange;

        [DBFieldName("SpellID", 5)]
        public int?[] SpellID;

        [DBFieldName("SpellTrigger", 5)]
        public int?[] SpellTrigger;

        [DBFieldName("SpellCharges", 5)]
        public int?[] SpellCharges;

        [DBFieldName("SpellCooldown", 5)]
        public int?[] SpellCooldown;

        [DBFieldName("SpellCategory", 5)]
        public uint?[] SpellCategory;

        [DBFieldName("SpellCategoryCooldown", 5)]
        public int?[] SpellCategoryCooldown;

        [DBFieldName("Bonding")]
        public int? Bonding;

        [DBFieldName("Display")]
        public string Display;

        [DBFieldName("Display1")]
        public string Display1;

        [DBFieldName("Display2")]
        public string Display2;

        [DBFieldName("Display3")]
        public string Display3;

        [DBFieldName("Description")]
        public string Description;

        [DBFieldName("PageText")]
        public uint? PageText;

        [DBFieldName("LanguageID")]
        public int? LanguageID;

        [DBFieldName("PageMaterial")]
        public int? PageMaterial;

        [DBFieldName("StartQuest")]
        public int? StartQuest;

        [DBFieldName("LockID")]
        public uint? LockID;

        [DBFieldName("Material")]
        public int? Material;

        [DBFieldName("SheatheType")]
        public int? SheatheType;

        [DBFieldName("RandomProperty")]
        public int? RandomProperty;

        [DBFieldName("RandomSuffix")]
        public uint? RandomSuffix;

        [DBFieldName("ItemSet")]
        public uint? ItemSet;

        [DBFieldName("AreaID")]
        public uint? AreaID;

        [DBFieldName("MapID")]
        public int? MapID;

        [DBFieldName("BagFamily")]
        public int? BagFamily;

        [DBFieldName("TotemCategory")]
        public int? TotemCategory;

        [DBFieldName("SocketColor", 3)]
        public int?[] SocketColor;

        [DBFieldName("Content", 3)]
        public uint?[] Content;

        [DBFieldName("SocketBonus")]
        public int? SocketBonus;

        [DBFieldName("GemProperties")]
        public int? GemProperties;

        [DBFieldName("ArmorDamageModifier")]
        public float? ArmorDamageModifier;

        [DBFieldName("Duration")]
        public uint? Duration;

        [DBFieldName("ItemLimitCategory")]
        public int? ItemLimitCategory;

        [DBFieldName("HolidayID")]
        public int? HolidayID;

        [DBFieldName("StatScalingFactor")]
        public float? StatScalingFactor;

        [DBFieldName("CurrencySubstitutionID")]
        public uint? CurrencySubstitutionID;

        [DBFieldName("CurrencySubstitutionCount")]
        public uint? CurrencySubstitutionCount;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
}
