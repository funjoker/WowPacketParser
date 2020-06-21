using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellInterrupts, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellInterrupts : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? DifficultyID;
        
        [DBFieldName("CHANGEME")]
        public short? InterruptFlags;
        
        [HotfixArray(2)]
        public int?[] AuraInterruptFlags;
        
        [HotfixArray(2)]
        public int?[] ChannelInterruptFlags;
        
        [DBFieldName("CHANGEME")]
        public int? SpellID;
    }
}
