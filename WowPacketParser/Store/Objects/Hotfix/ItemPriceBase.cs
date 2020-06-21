using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemPriceBase, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemPriceBase : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? ItemLevel;
        
        [DBFieldName("CHANGEME")]
        public float? Armor;
        
        [DBFieldName("CHANGEME")]
        public float? Weapon;
    }
}
