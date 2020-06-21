using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.BroadcastText)]
    [DBTableName("CHANGEME")]
    public sealed class BroadcastText : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Text;
        
        [DBFieldName("CHANGEME")]
        public string Text1;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public byte? LanguageID;
        
        [DBFieldName("CHANGEME")]
        public int? ConditionID;
        
        [DBFieldName("CHANGEME")]
        public ushort? EmotesID;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public uint? ChatBubbleDurationMs;
        
        [HotfixArray(2)]
        public uint?[] SoundEntriesID;
        
        [HotfixArray(3)]
        public ushort?[] EmoteID;
        
        [HotfixArray(3)]
        public ushort?[] EmoteDelay;
    }
}
