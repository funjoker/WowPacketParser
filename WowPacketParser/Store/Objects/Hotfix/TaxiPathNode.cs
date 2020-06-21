using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.TaxiPathNode, ClientVersionBuild.V8_0_1_27101, ClientVersionBuild.V8_1_0_28724)]
    [DBTableName("CHANGEME")]
    public sealed class TaxiPathNode : IDataModel
    {
        [HotfixArray(3)]
        public float?[] Loc;
        
        [DBFieldName("CHANGEME")]
        public int? ID;
        
        [DBFieldName("CHANGEME")]
        public ushort? PathID;
        
        [DBFieldName("CHANGEME")]
        public int? NodeIndex;
        
        [DBFieldName("CHANGEME")]
        public ushort? ContinentID;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public int? Delay;
        
        [DBFieldName("CHANGEME")]
        public ushort? ArrivalEventID;
        
        [DBFieldName("CHANGEME")]
        public ushort? DepartureEventID;
    }
}
