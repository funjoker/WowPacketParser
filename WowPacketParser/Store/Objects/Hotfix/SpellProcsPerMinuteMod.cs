using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellProcsPerMinuteMod, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellProcsPerMinuteMod : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? Type;
        
        [DBFieldName("CHANGEME")]
        public short? Param;
        
        [DBFieldName("CHANGEME")]
        public float? Coeff;
        
        [DBFieldName("CHANGEME")]
        public ushort? SpellProcsPerMinuteID;
    }
}
