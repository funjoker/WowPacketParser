using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.GarrBuildingPlotInst)]
    [DBTableName("CHANGEME")]
    public sealed class GarrBuildingPlotInst : IDataModel
    {
        [HotfixArray(2, true)]
        public float?[] MapOffset;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public byte? GarrBuildingID;
        
        [DBFieldName("CHANGEME")]
        public ushort? GarrSiteLevelPlotInstID;
        
        [DBFieldName("CHANGEME")]
        public ushort? UiTextureAtlasMemberID;
    }
}
