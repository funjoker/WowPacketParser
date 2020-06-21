using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.QuestSort, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class QuestSort : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string SortName;
        
        [DBFieldName("CHANGEME")]
        public sbyte? UiOrderIndex;
    }
}
