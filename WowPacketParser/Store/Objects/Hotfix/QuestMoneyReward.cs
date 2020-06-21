using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.QuestMoneyReward, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class QuestMoneyReward : IDataModel
    {
        [HotfixArray(10)]
        public uint?[] Difficulty;
    }
}
