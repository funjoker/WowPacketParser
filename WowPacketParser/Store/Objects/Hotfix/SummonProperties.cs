using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SummonProperties, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SummonProperties : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? Control;
        
        [DBFieldName("CHANGEME")]
        public int? Faction;
        
        [DBFieldName("CHANGEME")]
        public int? Title;
        
        [DBFieldName("CHANGEME")]
        public int? Slot;
        
        [DBFieldName("CHANGEME")]
        public int? Flags;
    }
}
