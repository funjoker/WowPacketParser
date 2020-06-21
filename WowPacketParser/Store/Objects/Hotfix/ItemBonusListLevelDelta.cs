using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemBonusListLevelDelta)]
    [DBTableName("CHANGEME")]
    public sealed class ItemBonusListLevelDelta : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public short? ItemLevelDelta;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
    }
}
