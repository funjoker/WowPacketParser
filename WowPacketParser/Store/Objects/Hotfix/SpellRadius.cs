using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellRadius, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellRadius : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public float? Radius;
        
        [DBFieldName("CHANGEME")]
        public float? RadiusPerLevel;
        
        [DBFieldName("CHANGEME")]
        public float? RadiusMin;
        
        [DBFieldName("CHANGEME")]
        public float? RadiusMax;
    }
}
