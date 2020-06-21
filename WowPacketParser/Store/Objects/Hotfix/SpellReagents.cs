using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellReagents, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellReagents : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? SpellID;
        
        [HotfixArray(8)]
        public int?[] Reagent;
        
        [HotfixArray(8)]
        public short?[] ReagentCount;
    }
}
