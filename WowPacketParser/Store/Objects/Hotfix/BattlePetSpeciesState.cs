using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.BattlePetSpeciesState, ClientVersionBuild.V8_0_1_27101, ClientVersionBuild.V8_1_0_28724, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class BattlePetSpeciesState : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? BattlePetStateID;
        
        [DBFieldName("CHANGEME")]
        public int? Value;
        
        [DBFieldName("CHANGEME")]
        public ushort? BattlePetSpeciesID;
    }
}
