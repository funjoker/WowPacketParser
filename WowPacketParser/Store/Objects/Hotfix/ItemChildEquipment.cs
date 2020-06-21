using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemChildEquipment, ClientVersionBuild.V8_0_1_27101, ClientVersionBuild.V8_1_0_28724, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemChildEquipment : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? ChildItemID;
        
        [DBFieldName("CHANGEME")]
        public byte? ChildItemEquipSlot;
        
        [DBFieldName("CHANGEME")]
        public int? ParentItemID;
    }
}
