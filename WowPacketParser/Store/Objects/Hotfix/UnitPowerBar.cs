using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.UnitPowerBar, ClientVersionBuild.V8_0_1_27101, ClientVersionBuild.V8_2_5_31921, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class UnitPowerBar : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public string Cost;
        
        [DBFieldName("CHANGEME")]
        public string OutOfError;
        
        [DBFieldName("CHANGEME")]
        public string ToolTip;
        
        [DBFieldName("CHANGEME")]
        public uint? MinPower;
        
        [DBFieldName("CHANGEME")]
        public uint? MaxPower;
        
        [DBFieldName("CHANGEME")]
        public ushort? StartPower;
        
        [DBFieldName("CHANGEME")]
        public byte? CenterPower;
        
        [DBFieldName("CHANGEME")]
        public float? RegenerationPeace;
        
        [DBFieldName("CHANGEME")]
        public float? RegenerationCombat;
        
        [DBFieldName("CHANGEME")]
        public byte? BarType;
        
        [DBFieldName("CHANGEME")]
        public ushort? Flags;
        
        [DBFieldName("CHANGEME")]
        public float? StartInset;
        
        [DBFieldName("CHANGEME")]
        public float? EndInset;
        
        [HotfixArray(6)]
        public int?[] FileDataID;
        
        [HotfixArray(6)]
        public int?[] Color;
    }
}
