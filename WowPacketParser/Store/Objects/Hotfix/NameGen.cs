using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.NameGen, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class NameGen : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public byte? RaceID;
        
        [DBFieldName("CHANGEME")]
        public byte? Sex;
    }
}
