using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.PvpDifficulty, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class PvpDifficulty : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? RangeIndex;
        
        [DBFieldName("CHANGEME")]
        public byte? MinLevel;
        
        [DBFieldName("CHANGEME")]
        public byte? MaxLevel;
        
        [DBFieldName("CHANGEME")]
        public ushort? MapID;
    }
}
