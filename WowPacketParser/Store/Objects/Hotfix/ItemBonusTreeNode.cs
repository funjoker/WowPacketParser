using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemBonusTreeNode, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemBonusTreeNode : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? ItemContext;
        
        [DBFieldName("CHANGEME")]
        public ushort? ChildItemBonusTreeID;
        
        [DBFieldName("CHANGEME")]
        public ushort? ChildItemBonusListID;
        
        [DBFieldName("CHANGEME")]
        public ushort? ChildItemLevelSelectorID;
        
        [DBFieldName("CHANGEME")]
        public ushort? ParentItemBonusTreeID;
    }
}
