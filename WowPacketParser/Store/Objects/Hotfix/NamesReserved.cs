using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.NamesReserved, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class NamesReserved : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
    }
}
