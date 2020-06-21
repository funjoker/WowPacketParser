using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.CharTitles, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class CharTitles : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public string Name1;
        
        [DBFieldName("CHANGEME")]
        public short? MaskID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? Flags;
    }
}
