using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.AzeriteTierUnlockSet, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class AzeriteTierUnlockSet : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? Flags;
    }
}
