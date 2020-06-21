using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.TransmogSet)]
    [DBTableName("CHANGEME")]
    public sealed class TransmogSet : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public int? ClassMask;
        
        [DBFieldName("CHANGEME")]
        public uint? TrackingQuestID;
        
        [DBFieldName("CHANGEME")]
        public int? Flags;
        
        [DBFieldName("CHANGEME")]
        public uint? TransmogSetGroupID;
        
        [DBFieldName("CHANGEME")]
        public int? ItemNameDescriptionID;
        
        [DBFieldName("CHANGEME")]
        public ushort? ParentTransmogSetID;
        
        [HotfixVersion(ClientVersionBuild.V8_1_0_28724, false)]
        public byte? Unknown810;
        
        [DBFieldName("CHANGEME")]
        public byte? ExpansionID;
        
        [HotfixVersion(ClientVersionBuild.V8_1_0_28724, false)]
        public int? PatchID;
        
        [DBFieldName("CHANGEME")]
        public short? UiOrder;
        
        [HotfixVersion(ClientVersionBuild.V8_2_5_31921, false)]
        public int? PlayerConditionID;
    }
}
