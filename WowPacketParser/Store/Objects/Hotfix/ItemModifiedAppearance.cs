using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemModifiedAppearance)]
    [DBTableName("CHANGEME")]
    public sealed class ItemModifiedAppearance : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public int? ItemID;
        
        [DBFieldName("CHANGEME")]
        public byte? ItemAppearanceModifierID;
        
        [DBFieldName("CHANGEME")]
        public ushort? ItemAppearanceID;
        
        [DBFieldName("CHANGEME")]
        public byte? OrderIndex;
        
        [DBFieldName("CHANGEME")]
        public sbyte? TransmogSourceTypeEnum;
    }
}
