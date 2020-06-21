using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellEffect, ClientVersionBuild.V8_0_1_27101, ClientVersionBuild.V8_2_5_31921, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellEffect : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? DifficultyID;
        
        [DBFieldName("CHANGEME")]
        public int? EffectIndex;
        
        [DBFieldName("CHANGEME")]
        public uint? Effect;
        
        [DBFieldName("CHANGEME")]
        public float? EffectAmplitude;
        
        [DBFieldName("CHANGEME")]
        public int? EffectAttributes;
        
        [DBFieldName("CHANGEME")]
        public short? EffectAura;
        
        [DBFieldName("CHANGEME")]
        public int? EffectAuraPeriod;
        
        [DBFieldName("CHANGEME")]
        public float? EffectBonusCoefficient;
        
        [DBFieldName("CHANGEME")]
        public float? EffectChainAmplitude;
        
        [DBFieldName("CHANGEME")]
        public int? EffectChainTargets;
        
        [DBFieldName("CHANGEME")]
        public int? EffectItemType;
        
        [DBFieldName("CHANGEME")]
        public int? EffectMechanic;
        
        [DBFieldName("CHANGEME")]
        public float? EffectPointsPerResource;
        
        [DBFieldName("CHANGEME")]
        public float? EffectPosFacing;
        
        [DBFieldName("CHANGEME")]
        public float? EffectRealPointsPerLevel;
        
        [DBFieldName("CHANGEME")]
        public int? EffectTriggerSpell;
        
        [DBFieldName("CHANGEME")]
        public float? BonusCoefficientFromAP;
        
        [DBFieldName("CHANGEME")]
        public float? PvpMultiplier;
        
        [DBFieldName("CHANGEME")]
        public float? Coefficient;
        
        [DBFieldName("CHANGEME")]
        public float? Variance;
        
        [DBFieldName("CHANGEME")]
        public float? ResourceCoefficient;
        
        [DBFieldName("CHANGEME")]
        public float? GroupSizeBasePointsCoefficient;
        
        [DBFieldName("CHANGEME")]
        public float? EffectBasePoints;
        
        [HotfixArray(2)]
        public int?[] EffectMiscValue;
        
        [HotfixArray(2)]
        public uint?[] EffectRadiusIndex;
        
        [HotfixArray(4)]
        public int?[] EffectSpellClassMask;
        
        [HotfixArray(2)]
        public short?[] ImplicitTarget;
        
        [DBFieldName("CHANGEME")]
        public int? SpellID;
    }
}
