using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellXSpellVisual)]
    [DBTableName("CHANGEME")]
    public sealed class SpellXSpellVisual : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? ID;
        
        [DBFieldName("CHANGEME")]
        public byte? DifficultyID;
        
        [DBFieldName("CHANGEME")]
        public uint? SpellVisualID;
        
        [DBFieldName("CHANGEME")]
        public float? Probability;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public byte? Priority;
        
        [DBFieldName("CHANGEME")]
        public int? SpellIconFileID;
        
        [DBFieldName("CHANGEME")]
        public int? ActiveIconFileID;
        
        [DBFieldName("CHANGEME")]
        public ushort? ViewerUnitConditionID;
        
        [DBFieldName("CHANGEME")]
        public uint? ViewerPlayerConditionID;
        
        [DBFieldName("CHANGEME")]
        public ushort? CasterUnitConditionID;
        
        [DBFieldName("CHANGEME")]
        public uint? CasterPlayerConditionID;
        
        [DBFieldName("CHANGEME")]
        public int? SpellID;
    }
}
