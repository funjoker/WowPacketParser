using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.EmotesTextSound, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class EmotesTextSound : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? RaceID;
        
        [DBFieldName("CHANGEME")]
        public byte? ClassID;
        
        [DBFieldName("CHANGEME")]
        public byte? SexID;
        
        [DBFieldName("CHANGEME")]
        public uint? SoundID;
        
        [DBFieldName("CHANGEME")]
        public ushort? EmotesTextID;
    }
}
