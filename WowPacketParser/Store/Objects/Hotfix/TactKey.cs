using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.TactKey, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class TactKey : IDataModel
    {
        [HotfixArray(16)]
        public byte?[] Key;
    }
}
