using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.GarrBuilding, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class GarrBuilding : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string HordeName;
        
        [DBFieldName("CHANGEME")]
        public string AllianceName;
        
        [DBFieldName("CHANGEME")]
        public string Description;
        
        [DBFieldName("CHANGEME")]
        public string Tooltip;
        
        [DBFieldName("CHANGEME")]
        public byte? GarrTypeID;
        
        [DBFieldName("CHANGEME")]
        public byte? BuildingType;
        
        [DBFieldName("CHANGEME")]
        public int? HordeGameObjectID;
        
        [DBFieldName("CHANGEME")]
        public int? AllianceGameObjectID;
        
        [DBFieldName("CHANGEME")]
        public byte? GarrSiteID;
        
        [DBFieldName("CHANGEME")]
        public byte? UpgradeLevel;
        
        [DBFieldName("CHANGEME")]
        public int? BuildSeconds;
        
        [DBFieldName("CHANGEME")]
        public ushort? CurrencyTypeID;
        
        [DBFieldName("CHANGEME")]
        public int? CurrencyQty;
        
        [DBFieldName("CHANGEME")]
        public ushort? HordeUiTextureKitID;
        
        [DBFieldName("CHANGEME")]
        public ushort? AllianceUiTextureKitID;
        
        [DBFieldName("CHANGEME")]
        public int? IconFileDataID;
        
        [DBFieldName("CHANGEME")]
        public ushort? AllianceSceneScriptPackageID;
        
        [DBFieldName("CHANGEME")]
        public ushort? HordeSceneScriptPackageID;
        
        [DBFieldName("CHANGEME")]
        public int? MaxAssignments;
        
        [DBFieldName("CHANGEME")]
        public byte? ShipmentCapacity;
        
        [DBFieldName("CHANGEME")]
        public ushort? GarrAbilityID;
        
        [DBFieldName("CHANGEME")]
        public ushort? BonusGarrAbilityID;
        
        [DBFieldName("CHANGEME")]
        public ushort? GoldCost;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
    }
}
