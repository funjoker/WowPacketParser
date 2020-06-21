using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ImportPriceShield, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ImportPriceShield : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public float? Data;
    }
}
