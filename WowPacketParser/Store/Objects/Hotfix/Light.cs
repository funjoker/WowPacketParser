using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.Light, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class Light : IDataModel
    {
        [HotfixArray(3, true)]
        public float?[] GameCoords;
        
        [DBFieldName("CHANGEME")]
        public float? GameFalloffStart;
        
        [DBFieldName("CHANGEME")]
        public float? GameFalloffEnd;
        
        [DBFieldName("CHANGEME")]
        public short? ContinentID;
        
        [HotfixArray(8)]
        public ushort?[] LightParamsID;
    }
}
