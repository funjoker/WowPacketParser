using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.WorldStateExpression, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class WorldStateExpression : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Expression;
    }
}
