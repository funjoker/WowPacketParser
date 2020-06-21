using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.EmotesText, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class EmotesText : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public ushort? EmoteID;
    }
}
