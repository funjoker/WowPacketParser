using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.Curve, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class Curve : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? Type;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
    }
}
