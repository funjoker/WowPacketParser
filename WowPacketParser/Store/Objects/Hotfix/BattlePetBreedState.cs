using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.BattlePetBreedState, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class BattlePetBreedState : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? BattlePetStateID;
        
        [DBFieldName("CHANGEME")]
        public ushort? Value;
        
        [DBFieldName("CHANGEME")]
        public byte? BattlePetBreedID;
    }
}
