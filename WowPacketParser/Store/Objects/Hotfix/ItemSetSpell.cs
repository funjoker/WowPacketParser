using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemSetSpell, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemSetSpell : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? ChrSpecID;
        
        [DBFieldName("CHANGEME")]
        public uint? SpellID;
        
        [DBFieldName("CHANGEME")]
        public byte? Threshold;
        
        [DBFieldName("CHANGEME")]
        public ushort? ItemSetID;
    }
}
