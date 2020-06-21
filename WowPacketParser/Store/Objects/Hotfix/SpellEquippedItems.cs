using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellEquippedItems, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellEquippedItems : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? SpellID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? EquippedItemClass;
        
        [DBFieldName("CHANGEME")]
        public int? EquippedItemInvTypes;
        
        [DBFieldName("CHANGEME")]
        public int? EquippedItemSubclass;
    }
}
