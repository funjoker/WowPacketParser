using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.TransmogSetItem)]
    [DBTableName("CHANGEME")]
    public sealed class TransmogSetItem : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public uint? TransmogSetID;
        
        [DBFieldName("CHANGEME")]
        public uint? ItemModifiedAppearanceID;
        
        [DBFieldName("CHANGEME")]
        public int? Flags;
    }
}
