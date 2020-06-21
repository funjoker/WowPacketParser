using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemXBonusTree, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemXBonusTree : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? ItemBonusTreeID;
        
        [DBFieldName("CHANGEME")]
        public int? ItemID;
    }
}
