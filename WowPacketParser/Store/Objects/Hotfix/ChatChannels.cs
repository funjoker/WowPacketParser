using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ChatChannels, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ChatChannels : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public string Shortcut;
        
        [DBFieldName("CHANGEME")]
        public int? Flags;
        
        [DBFieldName("CHANGEME")]
        public sbyte? FactionGroup;
    }
}
