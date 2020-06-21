using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellPower)]
    [DBTableName("CHANGEME")]
    public sealed class SpellPower : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? ID;
        
        [DBFieldName("CHANGEME")]
        public byte? OrderIndex;
        
        [DBFieldName("CHANGEME")]
        public int? ManaCost;
        
        [DBFieldName("CHANGEME")]
        public int? ManaCostPerLevel;
        
        [DBFieldName("CHANGEME")]
        public int? ManaPerSecond;
        
        [DBFieldName("CHANGEME")]
        public uint? PowerDisplayID;
        
        [DBFieldName("CHANGEME")]
        public int? AltPowerBarID;
        
        [DBFieldName("CHANGEME")]
        public float? PowerCostPct;
        
        [DBFieldName("CHANGEME")]
        public float? PowerCostMaxPct;
        
        [DBFieldName("CHANGEME")]
        public float? PowerPctPerSecond;
        
        [DBFieldName("CHANGEME")]
        public sbyte? PowerType;
        
        [DBFieldName("CHANGEME")]
        public int? RequiredAuraSpellID;
        
        [DBFieldName("CHANGEME")]
        public uint? OptionalCost;
        
        [DBFieldName("CHANGEME")]
        public int? SpellID;
    }
}
