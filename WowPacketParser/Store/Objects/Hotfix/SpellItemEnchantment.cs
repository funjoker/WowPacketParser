using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellItemEnchantment, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellItemEnchantment : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public string HordeName;
        
        [HotfixArray(3)]
        public uint?[] EffectArg;
        
        [HotfixArray(3)]
        public float?[] EffectScalingPoints;
        
        [DBFieldName("CHANGEME")]
        public uint? TransmogPlayerConditionID;
        
        [DBFieldName("CHANGEME")]
        public uint? TransmogCost;
        
        [DBFieldName("CHANGEME")]
        public uint? IconFileDataID;
        
        [HotfixArray(3)]
        public short?[] EffectPointsMin;
        
        [DBFieldName("CHANGEME")]
        public ushort? ItemVisual;
        
        [DBFieldName("CHANGEME")]
        public ushort? Flags;
        
        [DBFieldName("CHANGEME")]
        public ushort? RequiredSkillID;
        
        [DBFieldName("CHANGEME")]
        public ushort? RequiredSkillRank;
        
        [DBFieldName("CHANGEME")]
        public ushort? ItemLevel;
        
        [DBFieldName("CHANGEME")]
        public byte? Charges;
        
        [HotfixArray(3)]
        public byte?[] Effect;
        
        [DBFieldName("CHANGEME")]
        public sbyte? ScalingClass;
        
        [DBFieldName("CHANGEME")]
        public sbyte? ScalingClassRestricted;
        
        [DBFieldName("CHANGEME")]
        public byte? ConditionID;
        
        [DBFieldName("CHANGEME")]
        public byte? MinLevel;
        
        [DBFieldName("CHANGEME")]
        public byte? MaxLevel;
    }
}
