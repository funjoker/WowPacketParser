using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.WorldSafeLocs, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class WorldSafeLocs : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string AreaName;
        
        [HotfixArray(3, true)]
        public float?[] Loc;
        
        [DBFieldName("CHANGEME")]
        public ushort? MapID;
        
        [DBFieldName("CHANGEME")]
        public float? Facing;
    }
}