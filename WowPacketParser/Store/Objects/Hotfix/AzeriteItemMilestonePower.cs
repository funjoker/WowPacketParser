using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.AzeriteItemMilestonePower, ClientVersionBuild.V8_0_1_27101, ClientVersionBuild.V8_2_0_30898, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class AzeriteItemMilestonePower : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? RequiredLevel;
        
        [DBFieldName("CHANGEME")]
        public short? AzeritePowerID;
    }
}
