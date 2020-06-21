using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.QuestV2, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class QuestV2 : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? UniqueBitFlag;
    }
}
