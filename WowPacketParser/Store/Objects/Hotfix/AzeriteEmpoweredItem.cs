using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.AzeriteEmpoweredItem, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class AzeriteEmpoweredItem : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? ItemID;
        
        [DBFieldName("CHANGEME")]
        public uint? AzeriteTierUnlockSetID;
        
        [DBFieldName("CHANGEME")]
        public uint? AzeritePowerSetID;
    }
}
