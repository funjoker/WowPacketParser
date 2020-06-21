using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.QuestPackageItem, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class QuestPackageItem : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? PackageID;
        
        [DBFieldName("CHANGEME")]
        public int? ItemID;
        
        [DBFieldName("CHANGEME")]
        public uint? ItemQuantity;
        
        [DBFieldName("CHANGEME")]
        public byte? DisplayType;
    }
}
