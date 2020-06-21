using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellClassOptions, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellClassOptions : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? SpellID;
        
        [DBFieldName("CHANGEME")]
        public uint? ModalNextSpell;
        
        [DBFieldName("CHANGEME")]
        public byte? SpellClassSet;
        
        [HotfixArray(4)]
        public int?[] SpellClassMask;
    }
}
