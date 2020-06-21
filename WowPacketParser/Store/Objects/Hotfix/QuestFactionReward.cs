using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.QuestFactionReward, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class QuestFactionReward : IDataModel
    {
        [HotfixArray(10)]
        public short?[] Difficulty;
    }
}
