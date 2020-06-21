using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.RulesetItemUpgrade, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class RulesetItemUpgrade : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? ItemID;
        
        [DBFieldName("CHANGEME")]
        public ushort? ItemUpgradeID;
    }
}
