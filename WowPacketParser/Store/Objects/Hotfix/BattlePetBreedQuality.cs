using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.BattlePetBreedQuality, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class BattlePetBreedQuality : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public float? StateMultiplier;
        
        [DBFieldName("CHANGEME")]
        public byte? QualityEnum;
    }
}
