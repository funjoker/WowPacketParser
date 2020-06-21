using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.DurabilityQuality, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class DurabilityQuality : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public float? Data;
    }
}
