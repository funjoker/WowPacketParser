using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.CreatureType, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class CreatureType : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
    }
}
