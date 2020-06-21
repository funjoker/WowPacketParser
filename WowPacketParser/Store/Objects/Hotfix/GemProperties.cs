using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.GemProperties, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class GemProperties : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? EnchantId;
        
        [DBFieldName("CHANGEME")]
        public int? Type;
        
        [DBFieldName("CHANGEME")]
        public ushort? MinItemLevel;
    }
}
