using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.CharBaseSection, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class CharBaseSection : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? LayoutResType;
        
        [DBFieldName("CHANGEME")]
        public byte? VariationEnum;
        
        [DBFieldName("CHANGEME")]
        public byte? ResolutionVariationEnum;
    }
}
