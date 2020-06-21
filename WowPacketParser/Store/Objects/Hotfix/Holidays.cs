using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.Holidays, ClientVersionBuild.V8_0_1_27101, ClientVersionBuild.V8_1_0_28724)]
    [DBTableName("CHANGEME")]
    public sealed class Holidays : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? ID;
        
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
        
        [HotfixArray(16)]
        public int?[] Date;
        
        [HotfixArray(10)]
        public byte?[] CalendarFlags;
        
        [HotfixArray(3)]
        public int?[] TextureFileDataID;
    }
}
