using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemBonus, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemBonus : IDataModel
    {
        [HotfixArray(3)]
        public int?[] Value;
        
        [DBFieldName("CHANGEME")]
        public ushort? ParentItemBonusListID;
        
        [DBFieldName("CHANGEME")]
        public byte? Type;
        
        [DBFieldName("CHANGEME")]
        public byte? OrderIndex;
    }
}
