using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.Emotes, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class Emotes : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public long? RaceMask;
        
        [DBFieldName("CHANGEME")]
        public string EmoteSlashCommand;
        
        [DBFieldName("CHANGEME")]
        public int? AnimID;
        
        [DBFieldName("CHANGEME")]
        public uint? EmoteFlags;
        
        [DBFieldName("CHANGEME")]
        public byte? EmoteSpecProc;
        
        [DBFieldName("CHANGEME")]
        public uint? EmoteSpecProcParam;
        
        [DBFieldName("CHANGEME")]
        public uint? EventSoundID;
        
        [DBFieldName("CHANGEME")]
        public uint? SpellVisualKitID;
        
        [DBFieldName("CHANGEME")]
        public int? ClassMask;
    }
}
