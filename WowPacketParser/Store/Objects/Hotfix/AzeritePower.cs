using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.AzeritePower, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class AzeritePower : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? SpellID;
        
        [DBFieldName("CHANGEME")]
        public int? ItemBonusListID;
        
        [DBFieldName("CHANGEME")]
        public int? SpecSetID;
        
        [DBFieldName("CHANGEME")]
        public int? Flags;
    }
}
