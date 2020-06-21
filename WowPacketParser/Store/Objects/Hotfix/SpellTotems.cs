using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellTotems, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellTotems : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? SpellID;
        
        [HotfixArray(2)]
        public ushort?[] RequiredTotemCategoryID;
        
        [HotfixArray(2)]
        public int?[] Totem;
    }
}
