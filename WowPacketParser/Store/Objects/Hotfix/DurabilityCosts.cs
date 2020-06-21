using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.DurabilityCosts, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class DurabilityCosts : IDataModel
    {
        [HotfixArray(21)]
        public ushort?[] WeaponSubClassCost;
        
        [HotfixArray(8)]
        public ushort?[] ArmorSubClassCost;
    }
}
