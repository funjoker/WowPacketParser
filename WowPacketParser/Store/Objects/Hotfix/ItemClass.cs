using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemClass, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemClass : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string ClassName;
        
        [DBFieldName("CHANGEME")]
        public sbyte? ClassID;
        
        [DBFieldName("CHANGEME")]
        public float? PriceModifier;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
    }
}
