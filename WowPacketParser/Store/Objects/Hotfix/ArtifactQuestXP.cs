using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ArtifactQuestXP, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ArtifactQuestXP : IDataModel
    {
        [HotfixArray(10)]
        public uint?[] Difficulty;
    }
}
