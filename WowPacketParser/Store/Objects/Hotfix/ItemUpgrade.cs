using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemUpgrade, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemUpgrade : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? ItemUpgradePathID;
        
        [DBFieldName("CHANGEME")]
        public byte? ItemLevelIncrement;
        
        [DBFieldName("CHANGEME")]
        public ushort? PrerequisiteID;
        
        [DBFieldName("CHANGEME")]
        public ushort? CurrencyType;
        
        [DBFieldName("CHANGEME")]
        public uint? CurrencyAmount;
    }
}
