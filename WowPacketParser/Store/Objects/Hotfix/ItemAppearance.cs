using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemAppearance, ClientVersionBuild.V8_0_1_27101, ClientVersionBuild.V8_3_0_33062, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemAppearance : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? DisplayType;
        
        [HotfixVersion(ClientVersionBuild.V8_2_5_31921, false)]
        public int? SubclassID;
        
        [DBFieldName("CHANGEME")]
        public int? ItemDisplayInfoID;
        
        [DBFieldName("CHANGEME")]
        public int? DefaultIconFileDataID;
        
        [DBFieldName("CHANGEME")]
        public int? UiOrder;
    }
}
