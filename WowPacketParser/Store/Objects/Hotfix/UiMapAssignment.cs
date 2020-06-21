using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.UiMapAssignment)]
    [DBTableName("CHANGEME")]
    public sealed class UiMapAssignment : IDataModel
    {
        [HotfixArray(2, true)]
        public float?[] UiMin;
        
        [HotfixArray(2, true)]
        public float?[] UiMax;
        
        [HotfixArray(3, true)]
        public float?[] Region1;
        
        [HotfixArray(3, true)]
        public float?[] Region2;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public int? UiMapID;
        
        [DBFieldName("CHANGEME")]
        public int? OrderIndex;
        
        [DBFieldName("CHANGEME")]
        public int? MapID;
        
        [DBFieldName("CHANGEME")]
        public int? AreaID;
        
        [DBFieldName("CHANGEME")]
        public int? WmoDoodadPlacementID;
        
        [DBFieldName("CHANGEME")]
        public int? WmoGroupID;
    }
}
