using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.MountCapability)]
    [DBTableName("CHANGEME")]
    public sealed class MountCapability : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public ushort? ReqRidingSkill;
        
        [DBFieldName("CHANGEME")]
        public ushort? ReqAreaID;
        
        [DBFieldName("CHANGEME")]
        public uint? ReqSpellAuraID;
        
        [DBFieldName("CHANGEME")]
        public int? ReqSpellKnownID;
        
        [DBFieldName("CHANGEME")]
        public int? ModSpellAuraID;
        
        [DBFieldName("CHANGEME")]
        public short? ReqMapID;
        
        [HotfixVersion(ClientVersionBuild.V8_2_0_30898, false)]
        public int? PlayerConditionID;
    }
}
