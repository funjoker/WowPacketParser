using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemDamageTwoHand, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemDamageTwoHand : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? ItemLevel;
        
        [HotfixArray(7)]
        public float?[] Quality;
    }
}
