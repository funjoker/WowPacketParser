using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemDamageAmmo, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemDamageAmmo : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? ItemLevel;
        
        [HotfixArray(7)]
        public float?[] Quality;
    }
}
