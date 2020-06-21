using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.GameObjectDisplayInfo, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class GameObjectDisplayInfo : IDataModel
    {
        [HotfixArray(3, true)]
        public float?[] GeoBoxMin;
        
        [HotfixArray(3, true)]
        public float?[] GeoBoxMax;
        
        [DBFieldName("CHANGEME")]
        public int? FileDataID;
        
        [DBFieldName("CHANGEME")]
        public short? ObjectEffectPackageID;
        
        [DBFieldName("CHANGEME")]
        public float? OverrideLootEffectScale;
        
        [DBFieldName("CHANGEME")]
        public float? OverrideNameScale;
    }
}
