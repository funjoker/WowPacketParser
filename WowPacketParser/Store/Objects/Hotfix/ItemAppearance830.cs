using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParserModule.V8_3_0_33062.Hotfix
{
    [HotfixStructure(DB2Hash.ItemAppearance, ClientVersionBuild.V8_3_0_33062, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemAppearance : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? DisplayType;
        
        [DBFieldName("CHANGEME")]
        public int? ItemDisplayInfoID;
        
        [DBFieldName("CHANGEME")]
        public int? DefaultIconFileDataID;
        
        [DBFieldName("CHANGEME")]
        public int? UiOrder;
    }
}
