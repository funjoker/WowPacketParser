using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.GarrSiteLevel, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class GarrSiteLevel : IDataModel
    {
        [HotfixArray(2, true)]
        public float?[] TownHallUiPos;
        
        [DBFieldName("CHANGEME")]
        public uint? GarrSiteID;
        
        [DBFieldName("CHANGEME")]
        public byte? GarrLevel;
        
        [DBFieldName("CHANGEME")]
        public ushort? MapID;
        
        [DBFieldName("CHANGEME")]
        public ushort? UpgradeMovieID;
        
        [DBFieldName("CHANGEME")]
        public ushort? UiTextureKitID;
        
        [DBFieldName("CHANGEME")]
        public byte? MaxBuildingLevel;
        
        [DBFieldName("CHANGEME")]
        public ushort? UpgradeCost;
        
        [DBFieldName("CHANGEME")]
        public ushort? UpgradeGoldCost;
    }
}
