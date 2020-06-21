using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.GuildColorEmblem, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class GuildColorEmblem : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? Red;
        
        [DBFieldName("CHANGEME")]
        public byte? Blue;
        
        [DBFieldName("CHANGEME")]
        public byte? Green;
    }
}
