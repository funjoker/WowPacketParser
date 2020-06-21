using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.GarrSiteLevelPlotInst, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class GarrSiteLevelPlotInst : IDataModel
    {
        [HotfixArray(2, true)]
        public float?[] UiMarkerPos;
        
        [DBFieldName("CHANGEME")]
        public ushort? GarrSiteLevelID;
        
        [DBFieldName("CHANGEME")]
        public byte? GarrPlotInstanceID;
        
        [DBFieldName("CHANGEME")]
        public byte? UiMarkerSize;
    }
}
