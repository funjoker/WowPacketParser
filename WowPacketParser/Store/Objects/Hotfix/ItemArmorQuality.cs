using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemArmorQuality, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemArmorQuality : IDataModel
    {
        [HotfixArray(7)]
        public float?[] Qualitymod;
    }
}
