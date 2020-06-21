using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.Toy)]
    [DBTableName("CHANGEME")]
    public sealed class Toy : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string SourceText;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public int? ItemID;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public sbyte? SourceTypeEnum;
    }
}
