using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.KeyChain, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class KeyChain : IDataModel
    {
        [HotfixArray(32)]
        public byte?[] Key;
    }
}
