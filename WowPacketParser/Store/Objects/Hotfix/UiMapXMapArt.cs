using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.UiMapXMapArt, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class UiMapXMapArt : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? PhaseID;
        
        [DBFieldName("CHANGEME")]
        public int? UiMapArtID;
        
        [DBFieldName("CHANGEME")]
        public int? UiMapID;
    }
}
