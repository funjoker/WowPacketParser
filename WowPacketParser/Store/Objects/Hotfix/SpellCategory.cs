using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellCategory, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellCategory : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public sbyte? Flags;
        
        [DBFieldName("CHANGEME")]
        public byte? UsesPerWeek;
        
        [DBFieldName("CHANGEME")]
        public sbyte? MaxCharges;
        
        [DBFieldName("CHANGEME")]
        public int? ChargeRecoveryTime;
        
        [DBFieldName("CHANGEME")]
        public int? TypeMask;
    }
}
