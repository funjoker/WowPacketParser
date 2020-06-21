using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.WorldMapOverlay)]
    [DBTableName("CHANGEME")]
    public sealed class WorldMapOverlay : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? ID;
        
        [DBFieldName("CHANGEME")]
        public uint? UiMapArtID;
        
        [DBFieldName("CHANGEME")]
        public ushort? TextureWidth;
        
        [DBFieldName("CHANGEME")]
        public ushort? TextureHeight;
        
        [DBFieldName("CHANGEME")]
        public int? OffsetX;
        
        [DBFieldName("CHANGEME")]
        public int? OffsetY;
        
        [DBFieldName("CHANGEME")]
        public int? HitRectTop;
        
        [DBFieldName("CHANGEME")]
        public int? HitRectBottom;
        
        [DBFieldName("CHANGEME")]
        public int? HitRectLeft;
        
        [DBFieldName("CHANGEME")]
        public int? HitRectRight;
        
        [DBFieldName("CHANGEME")]
        public uint? PlayerConditionID;
        
        [DBFieldName("CHANGEME")]
        public uint? Flags;
        
        [HotfixArray(4)]
        public uint?[] AreaID;
    }
}
