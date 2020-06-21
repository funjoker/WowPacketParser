using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ImportPriceArmor, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ImportPriceArmor : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public float? ClothModifier;
        
        [DBFieldName("CHANGEME")]
        public float? LeatherModifier;
        
        [DBFieldName("CHANGEME")]
        public float? ChainModifier;
        
        [DBFieldName("CHANGEME")]
        public float? PlateModifier;
    }
}
