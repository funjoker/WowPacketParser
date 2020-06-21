using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ImportPriceWeapon, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ImportPriceWeapon : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public float? Data;
    }
}
