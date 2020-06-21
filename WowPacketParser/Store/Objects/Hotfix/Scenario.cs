using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.Scenario, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class Scenario : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public ushort? AreaTableID;
        
        [DBFieldName("CHANGEME")]
        public byte? Type;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public uint? UiTextureKitID;
    }
}
