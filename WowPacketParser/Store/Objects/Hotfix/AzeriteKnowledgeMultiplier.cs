using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.AzeriteKnowledgeMultiplier, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class AzeriteKnowledgeMultiplier : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public float? Multiplier;
    }
}
