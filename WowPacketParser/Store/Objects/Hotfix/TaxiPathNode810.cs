using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParserModule.V8_1_0_28724.Hotfix
{
    [HotfixStructure(DB2Hash.TaxiPathNode, ClientVersionBuild.V8_1_0_28724)]
    [DBTableName("CHANGEME")]
    public sealed class TaxiPathNode : IDataModel
    {
        [HotfixArray(3, true)]
        public float?[] Loc;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public ushort? PathID;
        
        [DBFieldName("CHANGEME")]
        public int? NodeIndex;
        
        [DBFieldName("CHANGEME")]
        public ushort? ContinentID;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public uint? Delay;
        
        [DBFieldName("CHANGEME")]
        public int? ArrivalEventID;
        
        [DBFieldName("CHANGEME")]
        public int? DepartureEventID;
    }
}
