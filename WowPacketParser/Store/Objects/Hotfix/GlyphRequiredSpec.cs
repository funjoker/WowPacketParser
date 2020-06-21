using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.GlyphRequiredSpec, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class GlyphRequiredSpec : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? ChrSpecializationID;
        
        [DBFieldName("CHANGEME")]
        public ushort? GlyphPropertiesID;
    }
}
