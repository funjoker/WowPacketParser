using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParserModule.V8_1_0_28724.Hotfix
{
    [HotfixStructure(DB2Hash.Holidays, ClientVersionBuild.V8_1_0_28724)]
    [DBTableName("CHANGEME")]
    public sealed class Holidays : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public ushort? Region;
        
        [DBFieldName("CHANGEME")]
        public byte? Looping;
        
        [DBFieldName("CHANGEME")]
        public uint? HolidayNameID;
        
        [DBFieldName("CHANGEME")]
        public uint? HolidayDescriptionID;
        
        [DBFieldName("CHANGEME")]
        public byte? Priority;
        
        [DBFieldName("CHANGEME")]
        public sbyte? CalendarFilterType;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [HotfixArray(10)]
        public ushort?[] Duration;
        
        [HotfixArray(26)]
        public uint?[] Date;
        
        [HotfixArray(10)]
        public byte?[] CalendarFlags;
        
        [HotfixArray(3)]
        public int?[] TextureFileDataID;
    }
}
