using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemArmorShield, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemArmorShield : IDataModel
    {
        [HotfixArray(7)]
        public float?[] Quality;
        
        [DBFieldName("CHANGEME")]
        public ushort? ItemLevel;
    }
}
