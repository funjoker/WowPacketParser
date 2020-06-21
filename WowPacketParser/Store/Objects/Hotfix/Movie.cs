using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.Movie, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class Movie : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? Volume;
        
        [DBFieldName("CHANGEME")]
        public byte? KeyID;
        
        [DBFieldName("CHANGEME")]
        public uint? AudioFileDataID;
        
        [DBFieldName("CHANGEME")]
        public uint? SubtitleFileDataID;
    }
}
