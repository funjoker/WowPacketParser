using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParserModule.V8_3_0_33062.Hotfix
{
    [HotfixStructure(DB2Hash.SpellVisualKit, ClientVersionBuild.V8_3_0_33062, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellVisualKit : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public sbyte? FallbackPriority;
        
        [DBFieldName("CHANGEME")]
        public int? FallbackSpellVisualKitId;
        
        [DBFieldName("CHANGEME")]
        public ushort? DelayMin;
        
        [DBFieldName("CHANGEME")]
        public ushort? DelayMax;
        
        [HotfixArray(2)]
        public int?[] Flags;
    }
}
