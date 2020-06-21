using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ChrClassesXPowerTypes, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ChrClassesXPowerTypes : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public sbyte? PowerType;
        
        [DBFieldName("CHANGEME")]
        public byte? ClassID;
    }
}
