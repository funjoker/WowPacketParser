using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.PvpItem, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class PvpItem : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? ItemID;
        
        [DBFieldName("CHANGEME")]
        public byte? ItemLevelDelta;
    }
}
