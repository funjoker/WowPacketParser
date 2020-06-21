using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.CorruptionEffects, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class CorruptionEffects : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public float? MinCorruption;
        
        [DBFieldName("CHANGEME")]
        public int? Aura;
        
        [DBFieldName("CHANGEME")]
        public int? PlayerConditionID;
        
        [DBFieldName("CHANGEME")]
        public int? Flags;
    }
}
