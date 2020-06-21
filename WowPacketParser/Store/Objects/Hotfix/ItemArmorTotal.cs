using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemArmorTotal, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemArmorTotal : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public short? ItemLevel;
        
        [DBFieldName("CHANGEME")]
        public float? Cloth;
        
        [DBFieldName("CHANGEME")]
        public float? Leather;
        
        [DBFieldName("CHANGEME")]
        public float? Mail;
        
        [DBFieldName("CHANGEME")]
        public float? Plate;
    }
}
