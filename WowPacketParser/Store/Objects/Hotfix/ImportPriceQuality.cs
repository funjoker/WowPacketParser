using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ImportPriceQuality, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ImportPriceQuality : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public float? Data;
    }
}
