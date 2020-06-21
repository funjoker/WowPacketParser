using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParserModule.V8_1_0_28724.Hotfix
{
    [HotfixStructure(DB2Hash.BattlePetSpeciesState, ClientVersionBuild.V8_1_0_28724, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class BattlePetSpeciesState : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? BattlePetStateID;
        
        [DBFieldName("CHANGEME")]
        public int? Value;
        
        [DBFieldName("CHANGEME")]
        public ushort? BattlePetSpeciesID;
    }
}
