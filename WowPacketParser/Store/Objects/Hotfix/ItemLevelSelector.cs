using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemLevelSelector, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemLevelSelector : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? MinItemLevel;
        
        [DBFieldName("CHANGEME")]
        public ushort? ItemLevelSelectorQualitySetID;
        
        [HotfixVersion(ClientVersionBuild.V8_1_0_28724, false)]
        public ushort? AzeriteUnlockMappingSet;
    }
}
