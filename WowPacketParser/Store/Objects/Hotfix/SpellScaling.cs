using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellScaling, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellScaling : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? SpellID;
        
        [DBFieldName("CHANGEME")]
        public int? Class;
        
        [DBFieldName("CHANGEME")]
        public uint? MinScalingLevel;
        
        [DBFieldName("CHANGEME")]
        public uint? MaxScalingLevel;
        
        [DBFieldName("CHANGEME")]
        public short? ScalesFromItemLevel;
    }
}
