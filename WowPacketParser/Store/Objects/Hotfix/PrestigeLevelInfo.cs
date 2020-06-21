using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.PrestigeLevelInfo, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class PrestigeLevelInfo : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public int? PrestigeLevel;
        
        [DBFieldName("CHANGEME")]
        public int? BadgeTextureFileDataID;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public int? AwardedAchievementID;
    }
}
