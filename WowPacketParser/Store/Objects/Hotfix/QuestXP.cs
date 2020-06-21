using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.QuestXP, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class QuestXP : IDataModel
    {
        [HotfixArray(10)]
        public ushort?[] Difficulty;
    }
}
