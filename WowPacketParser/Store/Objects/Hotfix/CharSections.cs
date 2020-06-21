using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.CharSections, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class CharSections : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public sbyte? RaceID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? SexID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? BaseSection;
        
        [DBFieldName("CHANGEME")]
        public sbyte? VariationIndex;
        
        [DBFieldName("CHANGEME")]
        public sbyte? ColorIndex;
        
        [DBFieldName("CHANGEME")]
        public short? Flags;
        
        [HotfixArray(3)]
        public int?[] MaterialResourcesID;
    }
}
