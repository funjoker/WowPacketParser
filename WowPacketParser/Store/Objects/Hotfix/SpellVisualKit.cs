using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellVisualKit, ClientVersionBuild.V8_0_1_27101, ClientVersionBuild.V8_3_0_33062, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellVisualKit : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? Flags;
        
        [DBFieldName("CHANGEME")]
        public sbyte? FallbackPriority;
        
        [DBFieldName("CHANGEME")]
        public int? FallbackSpellVisualKitId;
        
        [DBFieldName("CHANGEME")]
        public ushort? DelayMin;
        
        [DBFieldName("CHANGEME")]
        public ushort? DelayMax;
    }
}
