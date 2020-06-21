using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.GarrFollower, ClientVersionBuild.V8_0_1_27101, ClientVersionBuild.V8_2_0_30898)]
    [DBTableName("CHANGEME")]
    public sealed class GarrFollower : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string HordeSourceText;
        
        [DBFieldName("CHANGEME")]
        public string AllianceSourceText;
        
        [DBFieldName("CHANGEME")]
        public string TitleName;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public byte? GarrTypeID;
        
        [DBFieldName("CHANGEME")]
        public byte? GarrFollowerTypeID;
        
        [DBFieldName("CHANGEME")]
        public int? HordeCreatureID;
        
        [DBFieldName("CHANGEME")]
        public int? AllianceCreatureID;
        
        [DBFieldName("CHANGEME")]
        public byte? HordeGarrFollRaceID;
        
        [DBFieldName("CHANGEME")]
        public byte? AllianceGarrFollRaceID;
        
        [DBFieldName("CHANGEME")]
        public byte? HordeGarrClassSpecID;
        
        [DBFieldName("CHANGEME")]
        public byte? AllianceGarrClassSpecID;
        
        [DBFieldName("CHANGEME")]
        public byte? Quality;
        
        [DBFieldName("CHANGEME")]
        public byte? FollowerLevel;
        
        [DBFieldName("CHANGEME")]
        public ushort? ItemLevelWeapon;
        
        [DBFieldName("CHANGEME")]
        public ushort? ItemLevelArmor;
        
        [DBFieldName("CHANGEME")]
        public sbyte? HordeSourceTypeEnum;
        
        [DBFieldName("CHANGEME")]
        public sbyte? AllianceSourceTypeEnum;
        
        [DBFieldName("CHANGEME")]
        public int? HordeIconFileDataID;
        
        [DBFieldName("CHANGEME")]
        public int? AllianceIconFileDataID;
        
        [DBFieldName("CHANGEME")]
        public ushort? HordeGarrFollItemSetID;
        
        [DBFieldName("CHANGEME")]
        public ushort? AllianceGarrFollItemSetID;
        
        [DBFieldName("CHANGEME")]
        public ushort? HordeUITextureKitID;
        
        [DBFieldName("CHANGEME")]
        public ushort? AllianceUITextureKitID;
        
        [DBFieldName("CHANGEME")]
        public byte? Vitality;
        
        [DBFieldName("CHANGEME")]
        public byte? HordeFlavorGarrStringID;
        
        [DBFieldName("CHANGEME")]
        public byte? AllianceFlavorGarrStringID;
        
        [DBFieldName("CHANGEME")]
        public uint? HordeSlottingBroadcastTextID;
        
        [DBFieldName("CHANGEME")]
        public uint? AllySlottingBroadcastTextID;
        
        [DBFieldName("CHANGEME")]
        public byte? ChrClassID;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public byte? Gender;
    }
}
