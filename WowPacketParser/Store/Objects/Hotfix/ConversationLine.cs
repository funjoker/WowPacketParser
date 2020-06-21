using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ConversationLine, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ConversationLine : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public uint? BroadcastTextID;
        
        [DBFieldName("CHANGEME")]
        public uint? SpellVisualKitID;
        
        [DBFieldName("CHANGEME")]
        public int? AdditionalDuration;
        
        [DBFieldName("CHANGEME")]
        public ushort? NextConversationLineID;
        
        [DBFieldName("CHANGEME")]
        public ushort? AnimKitID;
        
        [DBFieldName("CHANGEME")]
        public byte? SpeechType;
        
        [DBFieldName("CHANGEME")]
        public byte? StartAnimation;
        
        [DBFieldName("CHANGEME")]
        public byte? EndAnimation;
    }
}
