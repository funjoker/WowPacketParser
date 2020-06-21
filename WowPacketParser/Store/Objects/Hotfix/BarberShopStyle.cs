using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.BarberShopStyle)]
    [DBTableName("CHANGEME")]
    public sealed class BarberShopStyle : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string DisplayName;
        
        [DBFieldName("CHANGEME")]
        public string Description;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public byte? Type;
        
        [DBFieldName("CHANGEME")]
        public float? CostModifier;
        
        [DBFieldName("CHANGEME")]
        public byte? Race;
        
        [DBFieldName("CHANGEME")]
        public byte? Sex;
        
        [DBFieldName("CHANGEME")]
        public byte? Data;
    }
}
