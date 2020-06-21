using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.MapDifficulty, ClientVersionBuild.V8_0_1_27101, ClientVersionBuild.V8_1_0_28724, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class MapDifficulty : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Message;
        
        [DBFieldName("CHANGEME")]
        public uint? ItemContextPickerID;
        
        [DBFieldName("CHANGEME")]
        public int? ContentTuningID;
        
        [DBFieldName("CHANGEME")]
        public byte? DifficultyID;
        
        [DBFieldName("CHANGEME")]
        public byte? LockID;
        
        [DBFieldName("CHANGEME")]
        public byte? ResetInterval;
        
        [DBFieldName("CHANGEME")]
        public byte? MaxPlayers;
        
        [DBFieldName("CHANGEME")]
        public byte? ItemContext;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public ushort? MapID;
    }
}
