using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.RandPropPoints, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class RandPropPoints : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? DamageReplaceStat;
        
        [HotfixVersion(ClientVersionBuild.V8_2_0_30898, false)]
        public int? DamageSecondary;
        
        [HotfixArray(5)]
        public uint?[] Epic;
        
        [HotfixArray(5)]
        public uint?[] Superior;
        
        [HotfixArray(5)]
        public uint?[] Good;
    }
}
