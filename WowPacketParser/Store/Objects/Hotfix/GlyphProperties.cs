using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.GlyphProperties, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class GlyphProperties : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public uint? SpellID;
        
        [HotfixVersion(ClientVersionBuild.V8_2_0_30898, true)]
        public ushort? SpellIconID;
        
        [DBFieldName("CHANGEME")]
        public byte? GlyphType;
        
        [DBFieldName("CHANGEME")]
        public byte? GlyphExclusiveCategoryID;
        
        [HotfixVersion(ClientVersionBuild.V8_2_0_30898, false)]
        public int? SpellIconFileDataID;
    }
}
