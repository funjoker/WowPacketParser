using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.Item, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class Item : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? ClassID;
        
        [DBFieldName("CHANGEME")]
        public byte? SubclassID;
        
        [DBFieldName("CHANGEME")]
        public byte? Material;
        
        [DBFieldName("CHANGEME")]
        public sbyte? InventoryType;
        
        [DBFieldName("CHANGEME")]
        public byte? SheatheType;
        
        [DBFieldName("CHANGEME")]
        public sbyte? SoundOverrideSubclassID;
        
        [DBFieldName("CHANGEME")]
        public int? IconFileDataID;
        
        [DBFieldName("CHANGEME")]
        public byte? ItemGroupSoundsID;
    }
}
