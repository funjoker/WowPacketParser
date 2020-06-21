using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemDamageOneHandCaster, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemDamageOneHandCaster : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? ItemLevel;
        
        [HotfixArray(7)]
        public float?[] Quality;
    }
}
