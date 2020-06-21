using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ArmorLocation, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ArmorLocation : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public float? Clothmodifier;
        
        [DBFieldName("CHANGEME")]
        public float? Leathermodifier;
        
        [DBFieldName("CHANGEME")]
        public float? Chainmodifier;
        
        [DBFieldName("CHANGEME")]
        public float? Platemodifier;
        
        [DBFieldName("CHANGEME")]
        public float? Modifier;
    }
}
