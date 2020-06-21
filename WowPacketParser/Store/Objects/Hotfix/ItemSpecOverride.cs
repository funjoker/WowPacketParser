using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemSpecOverride, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemSpecOverride : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? SpecID;
        
        [DBFieldName("CHANGEME")]
        public int? ItemID;
    }
}
