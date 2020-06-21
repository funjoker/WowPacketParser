using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParserModule.V8_1_0_28724.Hotfix
{
    [HotfixStructure(DB2Hash.ItemChildEquipment, ClientVersionBuild.V8_1_0_28724, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemChildEquipment : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? ParentItemID;
        
        [DBFieldName("CHANGEME")]
        public int? ChildItemID;
        
        [DBFieldName("CHANGEME")]
        public byte? ChildItemEquipSlot;
    }
}
