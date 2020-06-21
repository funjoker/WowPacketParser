using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.Phase, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class Phase : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? Flags;
    }
}
