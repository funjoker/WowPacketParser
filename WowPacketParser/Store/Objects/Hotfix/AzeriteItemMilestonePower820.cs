using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParserModule.V8_2_0_30898.Hotfix
{
    [HotfixStructure(DB2Hash.AzeriteItemMilestonePower, ClientVersionBuild.V8_2_0_30898)]
    [DBTableName("CHANGEME")]
    public sealed class AzeriteItemMilestonePower : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public int? RequiredLevel;
        
        [DBFieldName("CHANGEME")]
        public int? AzeritePowerID;
        
        [DBFieldName("CHANGEME")]
        public int? Type;
        
        [DBFieldName("CHANGEME")]
        public int? AutoUnlock;
    }
}
