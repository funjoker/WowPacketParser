using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellTargetRestrictions, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellTargetRestrictions : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? DifficultyID;
        
        [DBFieldName("CHANGEME")]
        public float? ConeDegrees;
        
        [DBFieldName("CHANGEME")]
        public byte? MaxTargets;
        
        [DBFieldName("CHANGEME")]
        public uint? MaxTargetLevel;
        
        [DBFieldName("CHANGEME")]
        public short? TargetCreatureType;
        
        [DBFieldName("CHANGEME")]
        public int? Targets;
        
        [DBFieldName("CHANGEME")]
        public float? Width;
        
        [DBFieldName("CHANGEME")]
        public int? SpellID;
    }
}
